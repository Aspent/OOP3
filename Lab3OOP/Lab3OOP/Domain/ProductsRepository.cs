using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3OOP.Domain
{
    class ProductsRepository
    {
        private List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}
