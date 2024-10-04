using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Commands
{
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}, and welcome to the micro-app LevelThree! What can I do for you?";
        }

        public string Description()
        {
            return "Hello {name}: Greets the user by name.";
        }
    }
}
