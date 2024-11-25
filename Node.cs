/* Node class for modeling graphs
 */

public class Node {
  protected string name;
  protected Dictionary<string, Node> edges = new Dictionary<string, Node>();
  
  public Node (string name) {
    this.name = name;
  }
  
  public String GetName() {
    return name;
  }
  
  public void AddEdge (string name, Node node) {
    edges.Add(name, node);
  }
  
  public virtual Node? FollowEdge (string direction) {
    if(edges.ContainsKey(direction) )
    {
      if(item == null || question == null || item.HoldingItem == true){
        return edges[direction];
      }
    } 
    else
    {
      return null;
    }
  }
}

