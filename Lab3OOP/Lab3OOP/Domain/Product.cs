using System;
using System.Collections.Generic;

namespace Lab3OOP.Domain
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
    }
}
