/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space beehive    = new Space("Beehive");
    Space have1 = new Space("Have1");
    Space have2_0  = new Space("Have2_0");
    Space have2_1  = new Space("Have2_1");
    Space have2_2  = new Space("Have2_2");
    
    beehive.AddEdge("beehive", beehive);
    have1_0.AddEdge("have1", have1);
    have2_0.AddEdge("have2_0", have2_0);
    have2_1.AddEdge("have2_1", have2_1);
    have2_2.AddEdge("have2_2", have2_2);
    
    
    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

