/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
  Item nektar = new Item("nektar", false);
  private string text;
  public Space (string name, string text) : base(name)
  {
	  this.text = text;
  }
  
  public void Welcome () {
    Console.WriteLine("---Du er nu ved "+name+ "---");
    Console.WriteLine(text);
    HashSet<string> paths = edges.Keys.ToHashSet();
    //If you enter the specific room player picks up item.
    // Only prints if it is set to true from false, if already true, it doesnt do anything
    if(name=="have1"){
      if(nektar.HoldingItem == false){
        nektar.HoldingItem = true;
        Console.WriteLine("***Du har nu samlet nektar op***");
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
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
