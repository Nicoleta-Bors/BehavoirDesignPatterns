using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_and_Iterator
{
    // Vizitatorul pentru a calcula prețul total
    class OrderVisitor : IOrderVisitor
    {
        public decimal Visit(Order order)
        {
            decimal total = 0;

            // Se itereaza prin produse si se calculeaza pretul total
            foreach (var product in order.GetProducts())
            {
                total += product.Price;
            }

            return total;
        }
    }
}
