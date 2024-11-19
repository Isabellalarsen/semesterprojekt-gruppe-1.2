/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Følg en vej";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    try {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("Det ved jeg ikke hvor er🤔");
      return;
    }
    context.Transition(parameters[0]);
    }
    catch {
      Console.WriteLine("Du fløj ind i hækken. prøv en mulig vej.");

    }
  }
}
