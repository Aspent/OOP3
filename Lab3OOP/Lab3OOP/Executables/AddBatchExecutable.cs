﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab3OOP.MenuEngine;
using Lab3OOP.Domain;

namespace Lab3OOP.Executables
{
    class AddBatchExecutable: IExecutable
    {
        private readonly BatchesRepository _batchesRepository;

        public AddBatchExecutable(BatchesRepository repository)
        {
            _batchesRepository = repository;
        }

        public void Execute()
        {
            Console.WriteLine("Введите название партии изделий");
            var barcode = Console.ReadLine();
            Console.WriteLine("Введите дату и время изготовления партии (в формате дд/мм/гггг час:минтута:секунда)");
            var releaseTime = DateTime.Parse(Console.ReadLine());
            var products = new List<Product>();

            var productsRepos = new ProductsRepository(products);
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

            var batch = new Batch(barcode, releaseTime, products);
            _batchesRepository.AddBatch(batch);
            Console.Clear();
        }
    }
}
