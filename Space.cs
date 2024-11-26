/* Space class for modeling spaces (rooms, caves, ...)
 */
using System.Net;
using System.Runtime.InteropServices;
using System.Transactions;

class Space : Node {
  static World    world    = new World();
  static Item[] pocket = new Item[5];
  static Inventory inventory = new Inventory("lomme", pocket);
  private int bees = 100;
  private string text;
  private bool beenHere;
  // The Item and question types can be null - as some of the constructors dont have Item and Question
  private Item? item;
  private Question? question;
  // If room has no item or question
  public Space (string name, string text, bool beenHere) : base(name)
  {
	  this.text = text;
    this.beenHere = beenHere;
  }
    // If room has no item but has a question
  public Space (string name, string text, bool beenHere, Question question) : base(name)
  {
	  this.text = text;
    this.beenHere = beenHere;
    this.question = question;
  }

  public Space(string name, string text, bool beenHere, Item item) : base(name)
  {
    this.text = text;
    this.beenHere = beenHere;
    this.item = item;
  }
  // If room has Item and question
  public Space (string name, string text, bool beenHere, Question question, Item item) : base(name)
  {
	  this.text = text;
    this.beenHere = beenHere;
    this.item = item;
    this.question = question;
  }
  
  public void Welcome () {


    Console.WriteLine("---Du er nu ved "+name+ "---");
    //Only slowprints if first time in room, could be annoying if it did it again
    if (!beenHere){
    Print.SlowPrint(text);
    } else{
      Console.WriteLine(text);
    }
    HashSet<string> paths = edges.Keys.ToHashSet();
    //If room has an item, and user doesnt have item
    //Set item to true and print
    // Only prints if it is set to true from false, if already true, it doesnt do anything
    if(item!=null){
      if(!item.HoldingItem){
            item.HoldingItem = true; // Automatically pick up the item
            inventory.AddItem(item);
            Console.WriteLine($"*** Du har nu samlet {item.Name} op ***");
            inventory.PrintInventory(pocket);
          }
    }
  
    // If room has a question do the following
    if(question!=null && !beenHere){
      Console.WriteLine(question.QuestionText);
      Console.WriteLine("For at svare skal du trykke på a, b, c eller d");
      // ReadKey() reads the next key pressed on keyboard
      char userAnswer = Console.ReadKey().KeyChar;
      Console.WriteLine();
      if(userAnswer == question.QuestionAnswer){
        Console.WriteLine($"Korrekt! Du har formået at redde {question.BeesLost} bier!");
      } else{
        bees = bees - question.BeesLost;
        Console.WriteLine($"Øv, det var ikke korrekt. Du har mistet {question.BeesLost} bier. Du har {bees} bier tilbage");
      }
    }

    if (!beenHere) {
        SetBeenHere(true);
    }
    //Checks amount of paths and prints accordingly.
    if (paths.Count > 0) {
      Console.WriteLine("Mulige veje:");
      foreach (String path in paths) {
        Console.WriteLine(" - "+path);
      }
    }
    //For the winning room, current text is placeholder.
    else {
      Console.WriteLine("Ingen mulige veje. Skriv 'bye' for at afslutte.");
    }
  }
  
  public void Goodbye () {
  }
  // Getter to check for first time in room or not
  public bool GetBeenHere(string name){
    return beenHere;
  }
  // Setter so we can set beenHere to true, when we enter room first time
  public void SetBeenHere(bool value){
    beenHere = value;
  }

  public override Space? FollowEdge (string direction) {
    direction = direction.ToLower();
    Space? nextroom = (Space?) (base.FollowEdge(direction));
    if (nextroom == null) {
      return null;
    }
    if (nextroom.item == null || nextroom.question == null || nextroom.item.HoldingItem == true){
      return (Space?) (base.FollowEdge(direction));
    }
    else
    {
      Console.WriteLine($"{direction} er låst, du mangler at samle en genstand op for at komme herind!");
      return FollowEdge(name);
    }
  }
}

