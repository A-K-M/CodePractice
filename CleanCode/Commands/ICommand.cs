using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Commands
{
    public interface ICommand
    {
        string Execute(string[] args);
        string Description();
    }
}
