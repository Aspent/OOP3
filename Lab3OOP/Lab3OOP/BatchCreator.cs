using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class BatchCreator
    {
        public Batch Create()
        {
            Console.WriteLine("Введите название партии изделий");
            var barcode = Console.ReadLine();
            Console.WriteLine("Введите дату и время изготовления партии (в формате дд/мм/гггг час:минтута:секунда)");
            var releaseTime = Convert.ToDateTime(Console.ReadLine());
            var products = new List<Product>();

            //Console.WriteLine("Введите количество изделий, входящих в партию");
            //var productCount = Convert.ToInt32(Console.ReadLine());
            //var products = new List<Product>();

            //for (var i = 1; i <= productCount; i++)
            //{
            //    Console.WriteLine("{0} изделие: ", i);
            //    var product = Product.CreateFromConsole();
            //    products.Add(product);
            //    Console.WriteLine();
            //}
            return new Batch(barcode, releaseTime, products);
        }
    }
}
