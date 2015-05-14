using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;

namespace Lab3OOP.Categories
{
    class FifthCategory : ICategory
    {
        public bool Belongs(Batch batch)
        {
            return true;
        }
    }
}
