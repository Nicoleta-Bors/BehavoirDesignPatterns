using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_and_Command
{
    public class ShoppingCart : ISubject
    {
        private List<string> items = new List<string>();
        private List<IObserver> observers = new List<IObserver>();

        public void AddItem(string item)
        {
            items.Add(item);
            NotifyObservers($"Item {item} added to cart.");
        }

        public void RemoveItem(string item)
        {
            items.Remove(item);
            NotifyObservers($"Item {item} removed from cart.");
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
