using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab3OOP.MenuEngine;

namespace Lab3OOP
{
    class AddBatchExecutable: IExecutable
    {

        public Batch Create()
        {
            Console.WriteLine("Введите название партии изделий");
            var barcode = Console.ReadLine();
            Console.WriteLine("Введите дату и время изготовления партии (в формате дд/мм/гггг час:минтута:секунда)");
            var releaseTime = Convert.ToDateTime(Console.ReadLine());
            var products = new List<Product>();
            return new Batch(barcode, releaseTime, products);
        }
    }
}
