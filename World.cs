/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;
  
  public World () {
	// Adding rooms of type space
    Space beehive = new Space("Beehive");
    Space have1 = new Space("have11");
    Space have2 = new Space("have2");
	Space have3 = new Space("have3");
    Space have3_1 = new Space("have3_1");
    Space have3_2  = new Space("have3_2");

	  //Adding edges - currentroom.Addedge("name_of_next_room", next_room)
    beehive.AddEdge("have1", have1);
    have1.AddEdge("have2", have2);
    have2.AddEdge("have3", have3);
	  // have3 has 2 edges, so it can move to 2 rooms
    have3.AddEdge("have3_1", have3_1);
    have3.AddEdge("have3_2", have3_2);
    have3_2.AddEdge("have3_1", have3_1);
    
    
    this.beehive = beehive;
  }
  
  public Space GetEntry () {
    return beehive;
  }
}

