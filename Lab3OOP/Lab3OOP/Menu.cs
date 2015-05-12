using System;
using System.Collections.Generic;

namespace Lab2
{
    class Menu
    {
        public void Run()
        {
            var batchCreator = new BatchCreator();
            var batch = batchCreator.Create();

            var productCreator = new ProductCreator();

            Console.WriteLine("Введите количество изделий, входящих в партию");
            var productCount = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= productCount; i++)
            {
                Console.WriteLine("{0} изделие: ", i);
                var product = productCreator.Create();

                Console.WriteLine("Введите количество записей в журнале рабочего времени");
                var entriesCount = Convert.ToInt32(Console.ReadLine());
                for (var j = 1; j <= entriesCount; j++)
                {
                    Console.WriteLine("Время работы в {0} записи: ", j);
                    var workLogEntryCreator = new WorkLogEntryCreator();
                    var workLogEntry = workLogEntryCreator.Create();
                    product.WorkLogEntries.Add(workLogEntry);
                    Console.WriteLine();
                }
                batch.Products.Add(product);                
            }

            var evaluator = new QualityEvaluator();
            Console.WriteLine("Категория качества партии {1} = {0}", evaluator.GetQualityCategory(batch), batch.Barcode);
        }
    }
}
