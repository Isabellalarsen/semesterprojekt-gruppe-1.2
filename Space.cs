/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
  Item nektar = new Item("nektar", false);
  public Space (String name) : base(name)
  {
  }
  
  public void Welcome () {
    Console.WriteLine("Du er nu ved "+name);
    HashSet<string> paths = edges.Keys.ToHashSet();
    if(name=="have1"){
        nektar.HoldingItem = true;
        Console.WriteLine("Du har nu samlet nektar op");
      }
    
    //Checks amount of paths and prints accordingly.
    if (paths.Count > 0) {
      Console.WriteLine("Mulige veje:");
      foreach (String path in paths) {
        Console.WriteLine(" - "+path);
      }
    }
    //Not sure what to do here if player wins...
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
