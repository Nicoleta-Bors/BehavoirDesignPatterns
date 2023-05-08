using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_and_Iterator
{
    class Order
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Iterator pentru a itera prin produsele comenzii
        public IEnumerable<Product> GetProducts()
        {
            foreach (var product in _products)
            {
                yield return product;
            }
        }

        // Visitor pentru a calcula prețul total
        public decimal Accept(OrderVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

}
