using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_and_Command
{
    public interface IObserver
    {
        void Update(string message);
    }
}
