using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Commands
{
    public class ListCommand : ICommand
    {
        private readonly Dictionary<string, ICommand> _commands;

        public ListCommand(Dictionary<string, ICommand> commands)
        {
            _commands = commands;
        }
        public string Execute(string[] args)
        {
            var result = new StringBuilder("Available commands:\n");
            foreach (var command in _commands)
            {
                result.AppendLine($"{command.Key}: {command.Value.Description()}");
            }
            return result.ToString();
        }


        public string Description()
        {
            return "List: Lists all available commands with descriptions.";
        }
    }
}
