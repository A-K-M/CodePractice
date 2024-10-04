using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Commands
{
    public class AddCommand : ICommand
    {
        public string Execute(string[] args)
        {
            if (int.TryParse(args[0], out int x) && int.TryParse(args[1], out int y))
            {
                return (x + y).ToString();
            }
            return "Invalid input. Both arguments must be integers.";
        }

        public string Description()
        {
            return "Add {x} {y}: Returns the sum of two integers.";
        }
    }
}
