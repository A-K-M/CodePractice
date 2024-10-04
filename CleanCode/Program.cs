using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.Commands;
using CleanCode.Services;

namespace CleanCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region mini app 
            IPrinterService printerService = new PrinterService();

            // Register all commands in a dictionary
            var commands = new Dictionary<string, ICommand>
            {
                { "Hello", new HelloCommand() },
                { "Add", new AddCommand() },
                { "Print", new PrintCommand(printerService) }
            };

            commands["List"] = new ListCommand(commands);

            // Pass the command dictionary to LevelThree
            var app = new LevelThree(commands);

            Console.WriteLine("Welcome to the micro-app LevelThree!");
            Console.WriteLine("Type 'exit' to quit the application.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the application.");
                    break;
                }

                string result = app.Execute(input);
                Console.WriteLine(result);
            }

            #endregion
        }
    }
}
