/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;
  
  public World () {
    Space beehive = new Space("Beehive");
    Space have1 = new Space("Have 1");
    Space have2 = new Space("Have 2");
	  Space have3 = new Space("Have 3");
    Space have3_1 = new Space("Have 3_1");
    Space have3_2  = new Space("Have 3_2");
    
    beehive.AddEdge("have1", have1);
    have1.AddEdge("have2", have2);
    have2.AddEdge("have3", have3);
    have3.AddEdge("have3_1", have3_1);
    have3.AddEdge("have3_2", have3_2);
    have3_2.AddEdge("have3_1", have3_1);
    
    
    this.beehive = beehive;
  }
  
  public Space GetEntry () {
    return beehive;
  }
}

