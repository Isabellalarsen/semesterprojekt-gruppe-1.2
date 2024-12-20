/* Help command
 */
namespace Domain
{
  class CommandHelp : BaseCommand, ICommand
  {
    Registry registry;

    public CommandHelp(Registry registry)
    {
      this.registry = registry;
      this.description = "Vis hjælpelisten";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
      string[] commandNames = registry.GetCommandNames();
      Array.Sort(commandNames);

      // find max length of command name
      int max = 0;
      foreach (String commandName in commandNames)
      {
        int length = commandName.Length;
        if (length > max) max = length;
      }

      // present list of commands
      Console.WriteLine("Kommandoer:");
      foreach (String commandName in commandNames)
      {
        string description = registry.GetCommand(commandName).GetDescription();
        Console.WriteLine(" - {0,-" + max + "} " + description, commandName);
      }
    }
  }
}