using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    class ChooseProductExecutable : IExecutable
    {
        private ProductsRepository _productsRepository;

        public ChooseProductExecutable(ProductsRepository repository)
        {
            _productsRepository = repository;
        }

        public void Execute()
        {
            Console.WriteLine("Введите номер изделия");
            var number = int.Parse(Console.ReadLine());
            var product = _productsRepository.GetByNumber(number);
            
            var workLogRepos = new WorkLogEntriesRepository(product.WorkLogEntries);
            Menu workLogMenu = new Menu();

            workLogMenu.AddCommand(new MenuCommand("Добавить новую запись о рабочем времени"
                , new AddWorkLogEntryExecutable(workLogRepos)));
            workLogMenu.AddCommand(new MenuCommand("Показать все записи"
                , new ShowWorkLogExecutable(workLogRepos)));
            workLogMenu.AddCommand(new MenuCommand("Продолжить"
                , new ContinueExecutable()));
            workLogMenu.Run();
        }
    }
}
