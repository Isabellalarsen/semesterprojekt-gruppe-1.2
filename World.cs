/* World class for modeling the entire in-game world
 */

class World {
  Space beehive;

  public World () {
	// Adding rooms of type space
    string beehiveText = "Du er lederbien “navn”, en modig bi fra en travl bikoloni midt i en kolonihave. Livet har været skønt med blomster i massevis og din store bislægt omkring dig - men pludselig! Du hører en uhyggelig brummen fra en bulldoser, der ruller ind og planlægger at rydde hele haven for at bygge noget nyt. Din mission: Red din koloni/hær/familie på 100 bier og find et nyt sted at bygge jer et hjem. På din rejse vil du møde udfordringer og svære valg - men hvis du er smart, kan du måske sikre din kolonis fremtid! For at redde din bi-hær skal du bevæge dig gennem kolonihaver. Hvis du vil bevæge dig til en bikube, skal du skrive go bikube. Du får at vide hvilke rum du kan bevæge dig ind i, når du får brug for det. Du skal tage valg eller svare på spørgsmål, der kan redde din bi-hær. For at svare på disse spørgsmål skal du skrive “a, b, c eller d”. Held og lykke!";
    string have1Text = "I svæver ind i Aviayas have, og det er som at træde ind i et eventyr! Blomsterne vokser vildt og farverigt, og luften er fyldt med den søde duft af nektar. Kolonien summer omkring dig, og alle er glade for at finde et sted med så meget mad.\n\nMen pludselig stopper du op. Summen falmer, da du ser, at nogle af blomsterne ser syge ud. Deres farve er falmede, og de visne kronblade hænger. Små, sorte skadedyr kravler på stilkene og suger livsblodet ud af planterne. Det er bladlus – de små grønne skabninger, der elsker at æde nektar og efterlader sig en klæbrig substans, der kan tiltrække endnu flere problemer. Du ser også grå, pudrede pletter, der spreder sig som en usynlig sygdom. Det er svampen, der truer med at ødelægge de smukke planter.\n\nHeldigvis er i stærke i kolonien! Jeres immunforsvar er i topform, så ingen bliver smittet med sygdommene, som befinder sig i haven. Men du ved, at det er bedst at være på din sikre side, så i beslutter at flyve videre og finde et bedre sted, hvor blomsterne ikke kun er farverige, men også sunde og friske.\n\nSelvom Aviayas have er fyldt med vilde blomster, så kan sygdomme være en stor udfordring for bier. Hvad vil der mon ske, hvis I blev her for længe? I vil ikke tage chancen – det er tid til at lede efter et mere sikkert tilholdssted.";

    Space beehive = new Space("beehives", beehiveText);
    Space have1 = new Space("have1", have1Text);
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
