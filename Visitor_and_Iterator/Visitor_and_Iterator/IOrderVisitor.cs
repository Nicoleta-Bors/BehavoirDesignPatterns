using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_and_Iterator
{
    // Interfața pentru vizitatorul de comenzi
    interface IOrderVisitor
    {
        decimal Visit(Order order);
    }
}
