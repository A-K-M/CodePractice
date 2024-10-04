using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Utils
{
    public class CommandParser
    {
        public (string commandName, string[] args) Parse(string input)
        {
            // Split the input by spaces into an array
            var parts = input.Split(' ');

            // The first part of the array is the command name
            var commandName = parts[0];

            // The remaining parts (after the first element) are the arguments
            var args = parts.Skip(1).ToArray();

            // Return both the command name and the arguments
            return (commandName, args);
        }
    }
}
