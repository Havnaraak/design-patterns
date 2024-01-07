

using Commands.Interfaces;

namespace Commands
{
    public class ControleInvoker
    {
        private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

        public void AddCommand(string key, ICommand command)
        {
            this.Commands.Add(key, command);
        }

        public void ExecuteCommand(string key)
        {
            if (!this.Commands.Keys.Contains(key))
            {
                Console.WriteLine("Comando inexistente");
            }
            else
            {
                this.Commands[key].Execute();
            }

        }

    }
}
