/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
  public Space (String name) : base(name)
  {
  }
  
  public void Welcome () {
    Console.WriteLine("You are now at "+name);
    HashSet<string> paths = edges.Keys.ToHashSet();
    Console.WriteLine("Current paths are:");
    foreach (String path in paths) {
      Console.WriteLine(" - "+path);
    }
  }
  
  public void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
