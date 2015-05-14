using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables 
{
    class ChooseBatchExecutable : IExecutable
    {
        private readonly BatchesRepository _batchesRepository;

        public ChooseBatchExecutable(BatchesRepository repository)
        {
            _batchesRepository = repository;
        }

        public void Execute()
        {
            Console.WriteLine("Введите номер партии");
            var number = int.Parse(Console.ReadLine());

            var batch = _batchesRepository.GetByNumber(number);

            var productsRepos = new ProductsRepository(batch.Products);
            Menu productMenu = new Menu();

            productMenu.AddCommand(new MenuCommand("Добавить новое изделие"
                , new AddProductExecutable(productsRepos)));
            productMenu.AddCommand(new MenuCommand("Выбрать изделие по номеру"
                , new ChooseProductExecutable(productsRepos)));
            productMenu.AddCommand(new MenuCommand("Показать все изделия"
                , new ShowProductsExecutable(productsRepos)));
            productMenu.AddCommand(new MenuCommand("Продолжить"
                , new ContinueExecutable()));
            productMenu.Run();
        }
    }
}
