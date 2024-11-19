/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;

  public World () {

    //Pulling text from textfiles and stores it in the string variable. 
    string beehiveText = File.ReadAllText(@"./stories/beehive.txt");
    string have1Text = File.ReadAllText(@"./stories/have1.txt");

    // Items
    Item nektar = new Item("nektar", false);
    Item nøgle1 = new Item("nøgle1", false);
    // (QuestionText, QuestionAnswer, BeesLost) QuestionAnswer must be in ' ' and only one char
    Question question1 = new Question("Hvad er 2+2?\n a: 3\n b: 4\n c: 5\n d:100", 'b', 10);
    Question question2 = new Question("Hvad er 2+2? a: 3, b: 4, c: 5, d:100", 'b', 10);
    // Adding rooms of type space (name, textofroom, beenHere, item)
    // Ignore item, if room has no items
    Space beehive = new Space("beehive", beehiveText, false);
    Space have1 = new Space("have1", have1Text, false, question1, nektar);
    Space have2 = new Space("have2", "test", false, question2, nøgle1);
	  Space have3 = new Space("have3", "test", false);
    Space have3_1 = new Space("have3_1", "test", false);
    Space have3_2  = new Space("have3_2", "test", false);

	  //Adding edges - currentroom.Addedge("name_of_next_room", next_room)
    beehive.AddEdge("have1", have1);
    have1.AddEdge("have2", have2);
    have2.AddEdge("tilbage", have1);
    have2.AddEdge("have3", have3);
	  // have3 has 2 edges, so it can move to 2 rooms
    have3.AddEdge("tilbage", have2);
    have3.AddEdge("have3_1", have3_1);
    have3.AddEdge("have3_2", have3_2);
    have3_2.AddEdge("tilbage", have3);
    have3_2.AddEdge("have3_1", have3_1);
    

    this.beehive = beehive;
  }
  
  public Space GetEntry () {
    return beehive;
  }
}
