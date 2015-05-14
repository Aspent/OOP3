using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.Executables;
using Lab3OOP.MenuEngine;

namespace Lab3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var batchesRepos = new BatchesRepository();
            Menu batchMenu = new Menu();

            batchMenu.AddCommand(new MenuCommand("Добавить новую партию изделий"
                , new AddBatchExecutable(batchesRepos)));
            batchMenu.AddCommand(new MenuCommand("Выбрать партию изделий по номеру"
                , new ChooseBatchExecutable(batchesRepos)));
            batchMenu.AddCommand(new MenuCommand("Показать все партии изделий"
                , new ShowBatchesExecutable(batchesRepos)));
            batchMenu.AddCommand(new MenuCommand("Оценить партию"
                , new EvaluateExecutable(batchesRepos)));
            batchMenu.AddCommand(new MenuCommand("Выход"
                , new ExitExecutable()));
            batchMenu.Run();

            Console.WriteLine("AHAHAHAHA");
            Console.ReadLine();
        }
    }
}
