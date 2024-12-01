/* World class for modeling the entire in-game world
 */

class World {
  Space bikube;

  public World () {

    //Pulling text from textfiles and stores it in the string variable. 
    string bikubeText = File.ReadAllText(@"./stories/beehive.txt");
    string aviayaText = File.ReadAllText(@"./stories/aviaya.txt");
    string fruHansenText = File.ReadAllText(@"./stories/fruhansen.txt");
    string solbergText = File.ReadAllText(@"./stories/solberg.txt");

    // Items
    Item bark = new Item("bark", false);
    Item nektar = new Item("nektar", false);
    Item pollen = new Item("pollen", false);
    Item vand = new Item("vand", false);

    // (QuestionText, QuestionAnswer, BeesLost) QuestionAnswer must be in ' ' and only one char
    Question testsQuestion = new Question("Hvad er 2+2?\n a: 3\n b: 4\n c: 5\n d:100", 'b', 0);
    Question aviayaQuestion = new Question("Hvad er bedst for en bi?\n a: Nyslået græs?\n b: Eksotiske planter fra andre lande?\n c: Indfødte planter, der blomstrer på forskellige tidspunkter?    ", 'c', 25);
    Question fruHansenQuestion = new Question("Hvorfor er det vigtigt at undgå brug af pesticider i haver?\n a: Fordi pesticider dræber bier og andre gavlige insekter\n b: Fordi pesticider gør planterne mindre grønne\n c: Fordi bier ikke kan lide lugten af pesticider  ", 'a', 25);
    Question solbergQuestion = new Question("Hvilken type vand foretrækker bier i sommervarmen?\n a: Friskt, koldt og rent vand\n b: Surt, og smålugtet vand med jord, mos og blade\n c: Vand med isterninger og citron ", 'b', 25);
    Question eventyrhaveQuestion = new Question("Hvad er godt at bestøve for en Bi?\n a: Rhododendron, Olieplanter og Balsamin Planter\n b: Planter med pesticidforurening\n c: Solhat, Valmue og bærbuske ", 'c', 25);

    
    // Adding rooms of type space (name, textofroom, beenHere, item)
    // Ignore item, if room has no items
    Space bikube = new Space("bikube", bikubeText, false, testsQuestion);
    Space aviayashave = new Space("aviayashave", aviayaText, false, aviayaQuestion);
    Space aviayasJordbund = new Space("jordbund", "test", false, bark);
	  Space fruHansen = new Space("fruHansen", fruHansenText, false, fruHansenQuestion, bark);
    Space fruHansensDrivhus = new Space("drivhus", "test", false, nektar);
    Space solberg  = new Space("solberg", solbergText, false, solbergQuestion, nektar);
    Space solbergVandpyt = new Space("vandslange","test", false, vand);
    Space eventyrhaven = new Space("eventyrhaven", "test", false, eventyrhaveQuestion, vand);
    Space eventyrhavenBlomsterbed = new Space("blomsterbed", "test", false, pollen);
    Space eng = new Space("eng", "test", false, pollen);

	  //Adding edges - currentroom.Addedge("name_of_next_room", next_room)
    bikube.AddEdge("aviaya", aviayashave);

    aviayashave.AddEdge("jordbund", aviayasJordbund);
    aviayashave.AddEdge("fruhansen", fruHansen);

    aviayasJordbund.AddEdge("tilbage", aviayashave);

	  // fruHansen has 2 edges, so it can move to 2 rooms
    fruHansen.AddEdge("tilbage", aviayasJordbund);
    fruHansen.AddEdge("drivhus", fruHansensDrivhus);
    fruHansen.AddEdge("solberg", solberg);

    fruHansensDrivhus.AddEdge("tilbage", fruHansen);

    solberg.AddEdge("tilbage", fruHansen);
    solberg.AddEdge("eventyrhaven", eventyrhaven);
    solberg.AddEdge("vandslange", solbergVandpyt);

    solbergVandpyt.AddEdge("tilbage", solberg);

    eventyrhaven.AddEdge("tilbage", solberg);
    eventyrhaven.AddEdge("blomsterbed", eventyrhavenBlomsterbed);
    eventyrhaven.AddEdge("eng", eng);

    eventyrhavenBlomsterbed.AddEdge("tilbage", eventyrhaven);
    this.bikube = bikube;
  }
  
  public Space GetEntry () {
    return bikube;
  }
}
