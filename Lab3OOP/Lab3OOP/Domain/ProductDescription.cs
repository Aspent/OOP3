﻿using System;

namespace Lab3OOP
{
    class ProductDescription
    {
        #region Fields

        private readonly string _aritcle;
        private readonly TimeSpan _standardTime;
        private readonly string _title;

        #endregion

        #region Constructor

        public ProductDescription(string article, TimeSpan standardTime, string title)
        {
            _aritcle = article;
            _standardTime = standardTime;
            _title = title;
        }

        #endregion

        #region Properties

        public string Article
        {
            get { return _aritcle; }
        }

        public TimeSpan StandardTime
        {
            get { return _standardTime; }
        }

        public string Title
        {
            get { return _title; }
        }

        #endregion

        #region Methods

        public void Show()
        {
            Console.WriteLine("Артикул: {0}", _aritcle);
            Console.WriteLine("Норма рабочего времени: {0}", _standardTime);
            Console.WriteLine("Название: {0}", _title);        
        }

        #endregion
    }
}
