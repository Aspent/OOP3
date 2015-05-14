using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    public class ExitExecutable : IExecutable
    {
        public void Execute()
        {
            Environment.Exit(0);           
        }
    }
}
