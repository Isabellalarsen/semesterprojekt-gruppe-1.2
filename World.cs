/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;

  public World () {

    //Pulling text from textfiles and stores it in the string variable. 
    string beehiveText = File.ReadAllText(@"./stories/beehive.txt");
    string aviayaText = File.ReadAllText(@"./stories/aviaya.txt");
    string fruHansenText = File.ReadAllText(@"./stories/fruhansen.txt");
    string solbergText = File.ReadAllText(@"./stories/solberg.txt");

    // Items
    Item vildBlomst = new Item("Vild blomst", false);
    Item nektar = new Item("nektar", false);
    Item nøgle1 = new Item("nøgle1", false);

    // (QuestionText, QuestionAnswer, BeesLost) QuestionAnswer must be in ' ' and only one char
    Question question1 = new Question("Hvad er 2+2?\n a: 3\n b: 4\n c: 5\n d:100", 'b', 10);
    Question question2 = new Question("Hvad er 2+2? a: 3, b: 4, c: 5, d:100", 'b', 10);
    // Adding rooms of type space (name, textofroom, beenHere, item)
    // Ignore item, if room has no items
    Space beehive = new Space("beehive", beehiveText, false);
    Space aviayashave = new Space("aviayashave", aviayaText, false, question1);
    Space aviayastree = new Space("aviayastree", "test", false, vildBlomst);
	  Space fruHansen = new Space("fruHansen", fruHansenText, false, question2, vildBlomst);
    Space fruHansenDrivhus = new Space("Drivhus", "test", false, nektar);
    Space solberg  = new Space("solberg", solbergText, false, nektar);
    Space terrasse = new Space("terrasse","test", false); 

	  //Adding edges - currentroom.Addedge("name_of_next_room", next_room)
    beehive.AddEdge("aviaya", aviayashave);
    aviayashave.AddEdge("aviayastree", aviayastree);
    aviayashave.AddEdge("fruhansen", fruHansen);
    aviayastree.AddEdge("tilbage", aviayashave);
	  // fruHansen has 2 edges, so it can move to 2 rooms
    fruHansen.AddEdge("tilbage", aviayastree);
    fruHansen.AddEdge("fruHansenDrivhus", fruHansenDrivhus);
    fruHansen.AddEdge("solberg", solberg);
    fruHansenDrivhus.AddEdge("tilbage", fruHansen);
    solberg.AddEdge("tilbage", fruHansen);
    solberg.AddEdge("terrasse", terrasse);

    this.beehive = beehive;
  }
  
  public Space GetEntry () {
    return beehive;
  }
}
