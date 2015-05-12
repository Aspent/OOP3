using System;

namespace Lab2
{
    class NomenclatureSelector
    {
        #region Fields

        readonly ProductDescription[] _nomenclatures = 
        {
            new ProductDescription("0000001", new TimeSpan(1, 30, 0), "Тарелка"),
            new ProductDescription("0000002", new TimeSpan(0, 45, 0), "Ложка"),
            new ProductDescription("0000003", new TimeSpan(0, 55, 0), "Вилка"),
            new ProductDescription("0000004", new TimeSpan(1, 10, 0), "Кружка"),
            new ProductDescription("0000005", new TimeSpan(2, 15, 0), "Кастрюля")
        };
    

        #endregion

        #region Methods

        private void ShowNomenclatures()
        {          
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите {0}, чтобы выбрать эту номенклатуру", i+1);
                _nomenclatures[i].Show();
                Console.WriteLine();
            }
        }

        public ProductDescription Select()
        {
            ShowNomenclatures();
            var choice = Convert.ToInt32(Console.ReadLine());
            if(choice >= 1 && choice <= 5)
            {
                return _nomenclatures[choice - 1];
            }
            return _nomenclatures[0];
        }

        #endregion
    }
}
