using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class ProductCreator
    {
        public Product Create()
        {
            Console.WriteLine("Введите серийный номер изделия");
            var serialNumber = Console.ReadLine();
            Console.WriteLine("Введите время изготовления изделия");
            var releaseDateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите true, если изделие является бракованным; false, если не является бракованным");
            var isDefective = Convert.ToBoolean(Console.ReadLine());
            var description = new NomenclatureSelector().Select();
            var workLogEntries = new List<WorkLogEntry>();

            return new Product(isDefective, releaseDateTime, serialNumber, description, workLogEntries);
        }
    }
}
