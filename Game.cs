/* Main class for launching the game
 */

using System.Net;

class Game {
  private int bees = 100;
  public int Bees {
      get { return bees; }
      set { bees = value; }
}
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);

      // Inventory
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("quit", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
  }
  
  static void Main (string[] args) {
    InitRegistry();
    context.GetCurrent().Welcome();
    
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Bierne har brug for dig 😥");
  }
}
