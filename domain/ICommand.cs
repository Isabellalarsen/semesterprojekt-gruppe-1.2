/* Command interface
 */
namespace Domain
{
    interface ICommand
    {
        void Execute(Context context, string command, string[] parameters);
        string GetDescription();
    }
}
