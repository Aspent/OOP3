using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    class AddProductExecutable : IExecutable
    {
        private readonly ProductsRepository _productsRepository;

        public AddProductExecutable(ProductsRepository repository)
        {
            _productsRepository = repository;
        }

        public void Execute()
        {
            Console.WriteLine("Введите серийный номер изделия");
            var serialNumber = Console.ReadLine();
            Console.WriteLine("Введите время изготовления изделия");
            var releaseDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если изделие является бракованным; false, если не является бракованным");
            var isDefective = bool.Parse(Console.ReadLine());
            var descriptions = new ProductDescriptionsRepository();
            var descriptionPrinter = new DescriptionPrinter(descriptions);
            descriptionPrinter.PrintAll();
            Console.WriteLine("Введите номер номенклатуры:");
            var number = int.Parse(Console.ReadLine());
            var description = descriptions.GetByNumber(number);
                
            var workLogEntries = new List<WorkLogEntry>();

            var workLogRepos = new WorkLogEntriesRepository(workLogEntries);
            Menu workLogMenu = new Menu();
            Console.Clear();

            workLogMenu.AddCommand(new MenuCommand("Добавить новую запись о рабочем времени"
                , new AddWorkLogEntryExecutable(workLogRepos)));
            workLogMenu.AddCommand(new MenuCommand("Показать все записи"
                , new ShowWorkLogExecutable(workLogRepos)));
            workLogMenu.AddCommand(new MenuCommand("Продолжить"
                , new ContinueExecutable()));
            workLogMenu.Run();
            var product = new Product(isDefective, releaseDateTime, serialNumber, description, workLogEntries);
            _productsRepository.AddProduct(product);
            
        }
    }
}
