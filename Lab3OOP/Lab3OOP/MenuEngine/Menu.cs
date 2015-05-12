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
            }
        }

        public int ReadCommand()
        {
            Console.WriteLine("Введите номер команды: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public void ExecuteCommand(int number)
        {
            _commands[number - 1].Execute();

        }

        public void Run()
        {
            while(true)
            {
                PrintCommands();
                var number = ReadCommand();
                ExecuteCommand(number);
            }
        }

        //public void Run()
        //{
        //    var batchCreator = new BatchCreator();
        //    var batch = batchCreator.Create();

        //    var productCreator = new ProductCreator();

        //    Console.WriteLine("Введите количество изделий, входящих в партию");
        //    var productCount = Convert.ToInt32(Console.ReadLine());

        //    for (var i = 1; i <= productCount; i++)
        //    {
        //        Console.WriteLine("{0} изделие: ", i);
        //        var product = productCreator.Create();

        //        Console.WriteLine("Введите количество записей в журнале рабочего времени");
        //        var entriesCount = Convert.ToInt32(Console.ReadLine());
        //        for (var j = 1; j <= entriesCount; j++)
        //        {
        //            Console.WriteLine("Время работы в {0} записи: ", j);
        //            var workLogEntryCreator = new WorkLogEntryCreator();
        //            var workLogEntry = workLogEntryCreator.Create();
        //            product.WorkLogEntries.Add(workLogEntry);
        //            Console.WriteLine();
        //        }
        //        batch.Products.Add(product);
        //    }

        //    var evaluator = new QualityEvaluator();
        //    Console.WriteLine("Категория качества партии {1} = {0}", evaluator.GetQualityCategory(batch), batch.Barcode);
        //}
    }
}
