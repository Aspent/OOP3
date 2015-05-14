using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;
using Lab3OOP.Categories;

namespace Lab3OOP.Executables
{
    class EvaluateExecutable : IExecutable
    {
        private readonly BatchesRepository _batchesRepository;

        public EvaluateExecutable(BatchesRepository repository)
        {
            _batchesRepository = repository;
        }
        public void Execute()
        {
            var categories = new List<ICategory>();
            categories.Add(new FirstCategory());
            categories.Add(new SecondCategory());
            categories.Add(new ThirdCategory());
            categories.Add(new FourthCategory());
            categories.Add(new FifthCategory());

            Console.WriteLine("Введите номер партии");
            var number = int.Parse(Console.ReadLine());
            var batch = _batchesRepository.GetByNumber(number);
            for(int i=1; i<=categories.Count; i++)
            {
                if(categories[i-1].Belongs(batch))
                {
                    Console.WriteLine("{0}-я категория", i);
                    break;
                }
            }
        }
    }
}
