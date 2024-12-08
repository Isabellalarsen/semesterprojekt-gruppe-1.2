/* Command for exiting program
 */
namespace Domain
{
  class CommandExit : BaseCommand, ICommand
  {
    public void Execute(Context context, string command, string[] parameters)
    {
      context.MakeDone();
    }

    public CommandExit()
    {
      description = "Afslut spillet";
    }
  }
}