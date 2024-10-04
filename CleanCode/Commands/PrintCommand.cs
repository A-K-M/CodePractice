using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.Services;

namespace CleanCode.Commands
{
    public class PrintCommand : ICommand
    {
        private readonly IPrinterService _printerService;

        public PrintCommand(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        public string Execute(string[] args)
        {
            _printerService.PrintFile(args[0]);
            return $"Printing file {args[0]}...";

        }
        public string Description()
        {
            return "Print {filename}: Sends a print order to the printer.";
        }
    }
}
