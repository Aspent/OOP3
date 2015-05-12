using System;
using System.Collections.Generic;

namespace Lab2
{
    class Batch
    {
        #region Fields

        private readonly string _barcode;
        private readonly DateTime _releaseDate;
        private readonly List<Product> _products;

        #endregion

        #region Constructor

        public Batch(string barcode, DateTime releaseDate, List<Product> products)
        {
            _barcode = barcode;
            _releaseDate = releaseDate;
            _products = products;
        }

        #endregion

        #region Properties

        public string Barcode
        {
            get { return _barcode; }
        }

        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
        }

        public List<Product> Products
        {
            get { return _products; }
        }


        #endregion

        #region Methods

        //public static Batch CreateFromConsole()
        //{
        //    Console.WriteLine("Введите название партии изделий");
        //    var barcode = Console.ReadLine();
        //    Console.WriteLine("Введите дату и время изготовления партии (в формате дд/мм/гггг час:минтута:секунда)");
        //    var releaseTime = Convert.ToDateTime(Console.ReadLine());

        //    Console.WriteLine("Введите количество изделий, входящих в партию");
        //    var productCount = Convert.ToInt32(Console.ReadLine());
        //    var products = new List<Product>();

        //    for (var i = 1; i <= productCount; i++)
        //    {
        //        Console.WriteLine("{0} изделие: ", i);
        //        var product = Product.CreateFromConsole();
        //        products.Add(product);
        //        Console.WriteLine();
        //    }
        //    return new Batch(barcode, releaseTime, products);
        //}

        #endregion
    }
}
