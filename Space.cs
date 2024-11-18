/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {

  private string text;
  private bool beenHere;

  // The Item type can be null - Necessarry for later items involving Item types
  private Item? item;

    // If room has no item
    public Space (string name, string text, bool beenHere) : base(name)
  {
	  this.text = text;
    this.beenHere = beenHere;
  }
  // Two contructors, one if space has item, one if not
  public Space (string name, string text, bool beenHere, Item item) : base(name)
  {
	  this.text = text;
    this.beenHere = beenHere;
    this.item = item;
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
            Console.WriteLine("*** Du har nu samlet " + item.name + " op ***");
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

  /* Hvis vi senere vil sætte item attributterne til private - kan vi lige snakke om
  // If item doesnt exist, returns "No item" - Strings are not null-able so has to return something
  public string GetItemName(){
    return item?.name ?? "No item";
  }
  
  // Kan tage imod null values. Hvis space ikke har en item, returneres false
  public bool GetItemStatus(){
    return item?.HoldingItem ?? false;
  }
  // Setter for item status.
  public void SetItemStatus(bool status) {
    if (item != null) {
        item.HoldingItem = status;
    } else {
        Console.WriteLine("Der er ingen genstand her.");
    }
  }
  */
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
