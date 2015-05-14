using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    class ShowProductsExecutable : IExecutable
    {
        private ProductsRepository _productsRepository;

        public ShowProductsExecutable(ProductsRepository repository)
        {
            _productsRepository = repository;
        }

        public void Execute()
        {
            var products = _productsRepository.GetAll();
            var descriptionPrinter = new DescriptionPrinter(new ProductDescriptionsRepository());
            for (var i = 1; i <= products.Count; i++) 
            {
                Console.WriteLine("{0}: {1}, {2}", i, products[i-1].SerialNumber, products[i-1].ReleaseDateTime);
                Console.WriteLine("Номенклатура: ");
                descriptionPrinter.PrintDescription(products[i - 1].Description);
            }
        }
    }
}
