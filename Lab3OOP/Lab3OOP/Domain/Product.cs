using System;
using System.Collections.Generic;

namespace Lab3OOP
{
    class Product
    {
        #region Fields

        private readonly bool _isDefective;
        private readonly DateTime _releaseDateTime;
        private readonly string _serialNumber;
        private readonly ProductDescription _description;
        private readonly List<WorkLogEntry> _workLogEntries; 

        #endregion

        #region Constructor

        public Product(bool isDefective,DateTime releaseDateTime, string serialNumber, 
            ProductDescription description, List<WorkLogEntry> workLogEntries) 
        {
            _isDefective = isDefective;
            _releaseDateTime = releaseDateTime;
            _serialNumber = serialNumber;
            _description = description;
            _workLogEntries = workLogEntries;
        }

        #endregion

        #region Properties

        public bool IsDefective
        {
            get { return _isDefective; }
        }

        public DateTime ReleaseDateTime
        {
            get { return _releaseDateTime; }
        }

        public string SerialNumber
        {
            get { return _serialNumber; }
        }

        public ProductDescription Description
        {
            get { return _description; }
        }

        public List<WorkLogEntry> WorkLogEntries
        {
            get { return _workLogEntries; }
        }

        public TimeSpan TotalTimeSpent
        {
            get
            {
                var totalTime = new TimeSpan();
                foreach (var workLog in _workLogEntries)
                {
                    totalTime += workLog.TimeSpent;
                }
                return totalTime;
            }
        }

        #endregion

        #region Methods

        //public static Product CreateFromConsole()
        //{
        //    Console.WriteLine("Введите серийный номер изделия");
        //    var serialNumber = Console.ReadLine();
        //    Console.WriteLine("Введите время изготовления изделия");
        //    var releaseDateTime = Convert.ToDateTime(Console.ReadLine());
        //    Console.WriteLine("Введите true, если изделие является бракованным; false, если не является бракованным");
        //    var isDefective = Convert.ToBoolean(Console.ReadLine());
        //    var description = new NomenclatureSelector().Select();

        //    Console.WriteLine("Введите количество записей в журнале рабочего времени");
        //    var count = Convert.ToInt32(Console.ReadLine());
        //    var workLogEntries = new List<WorkLogEntry>();
        //    for (var i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine("Время работы в {0} записи: ", i);
        //        workLogEntries.Add(WorkLogEntry.CreateFromConsole());
        //        Console.WriteLine();
        //    }

        //    return new Product(isDefective, releaseDateTime, serialNumber, description, workLogEntries);
        //}

        #endregion
    }
}
