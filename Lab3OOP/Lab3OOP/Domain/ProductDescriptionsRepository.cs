using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3OOP.Domain
{
    class ProductDescriptionsRepository
    {
        private readonly List<ProductDescription> _productDescriptions = new List<ProductDescription>();

        public void AddDescription(ProductDescription description)
        {
            _productDescriptions.Add(description);
        }

        public ProductDescription GetByNumber(int number)
        {
            return _productDescriptions[number - 1];
        }
    }
}
