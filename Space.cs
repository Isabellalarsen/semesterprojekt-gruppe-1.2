/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {

  private string text;
  private bool beenHere;

  // The Item type can be null - Necessarry for later items involving Item types
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
    Console.WriteLine(text);
    HashSet<string> paths = edges.Keys.ToHashSet();
    //If room has an item, and user doesnt have item
    //Set item to true and print
    // Only prints if it is set to true from false, if already true, it doesnt do anything
    if(item!=null){
      if(!item.HoldingItem){
            item.HoldingItem = true; // Automatically pick up the item
            Console.WriteLine("*** Du har nu samlet " + item.Name + " op ***");
        }
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

  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
