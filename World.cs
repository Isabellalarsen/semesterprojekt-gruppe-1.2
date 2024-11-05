/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;

  public World () {
	// Adding rooms of type space
    string beehiveText = "Du er lederbien “navn”, en modig bi fra en travl bikoloni midt i en kolonihave. Livet har været skønt med blomster i massevis og din store bislægt omkring dig - men pludselig! Du hører en uhyggelig brummen fra en bulldoser, der ruller ind og planlægger at rydde hele haven for at bygge noget nyt. Din mission: Red din koloni/hær/familie på 100 bier og find et nyt sted at bygge jer et hjem. På din rejse vil du møde udfordringer og svære valg - men hvis du er smart, kan du måske sikre din kolonis fremtid! For at redde din bi-hær skal du bevæge dig gennem kolonihaver. Hvis du vil bevæge dig til en bikube, skal du skrive go bikube. Du får at vide hvilke rum du kan bevæge dig ind i, når du får brug for det. Du skal tage valg eller svare på spørgsmål, der kan redde din bi-hær. For at svare på disse spørgsmål skal du skrive “a, b, c eller d”. Held og lykke!;

    Space beehive = new Space("beehive", beehiveText);
    Space have1 = new Space("have1", "test");
    Space have2 = new Space("have2", "test");
	  Space have3 = new Space("have3", "test");
    Space have3_1 = new Space("have3_1", "test");
    Space have3_2  = new Space("have3_2", "test");

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

