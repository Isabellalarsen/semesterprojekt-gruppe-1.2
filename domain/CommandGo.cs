/* Command for transitioning between spaces
 */
namespace Domain
{
  class CommandGo : BaseCommand, ICommand
  {
    public CommandGo()
    {
      description = "Følg en vej";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
      if (GuardEq(parameters, 1))
      {
        Console.WriteLine("Det ved jeg ikke hvor er🤔");
        return;
      }

      context.Transition(parameters[0]);
    }
  }
}
