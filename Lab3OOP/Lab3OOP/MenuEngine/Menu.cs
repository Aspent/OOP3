using System;
using System.Collections.Generic;

namespace Lab3OOP.MenuEngine
{
    class Menu
    {
        List<MenuCommand> _commands = new List<MenuCommand>();
        
        public void AddCommand(MenuCommand command)
        {
            _commands.Add(command);
        }

        public void PrintCommands()
        {
            int number = 1;
            foreach(var t in _commands)
            {
                Console.WriteLine("{0} - {1}", number, t.Title);
                number++;
            }
        }

        public int ReadCommand()
        {
            Console.WriteLine("Введите номер команды: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return number;
            
        }

        public void ExecuteCommand(int number)
        {
            _commands[number - 1].Execute();

        }

        public void Run()
        {
            Console.Clear();
            while(true)
            {
                PrintCommands();
                var number = ReadCommand();   
                ExecuteCommand(number);
                if(number == _commands.Count)
                {
                    break;
                }
            }
        }
    }
}
