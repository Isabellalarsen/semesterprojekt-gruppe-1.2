/* Main class for launching the game
 */

class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
  }
  
  static void Main (string[] args) {
        Console.WriteLine("Du er lederbien “navn”, en modig bi fra en travl bikoloni midt i en kolonihave. Livet har været skønt med blomster i massevis og din store bislægt omkring dig - men pludselig! Du hører en uhyggelig brummen fra en bulldoser, der ruller ind og planlægger at rydde hele haven for at bygge noget nyt.");
        Console.WriteLine("Din mission: Red din koloni/hær/familie på 100 bier og find et nyt sted at bygge jer et hjem. På din rejse vil du møde udfordringer og svære valg - men hvis du er smart, kan du måske sikre din kolonis fremtid!");
        Console.WriteLine("For at redde din bi-hær skal du bevæge dig gennem kolonihaver. Hvis du vil bevæge dig til en bikube, skal du skrive go bikube. Du får at vide hvilke rum du kan bevæge dig ind i, når du får brug for det. Du skal tage valg eller svare på spørgsmål, der kan redde din bi-hær. For at svare på disse spørgsmål skal du skrive “a, b, c eller d”. Held og lykke!");
  
    
    InitRegistry();
    context.GetCurrent().Welcome();
    
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Game Over 😥");
  }
}
