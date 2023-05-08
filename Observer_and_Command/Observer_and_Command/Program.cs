using System;
using System.Collections.Generic;

namespace Observer_and_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            ConsoleObserver observer = new ConsoleObserver();

            cart.RegisterObserver(observer);

            ICommand addBread = new AddItemCommand(cart, "Bread");
            ICommand addMilk = new AddItemCommand(cart, "Milk");
            ICommand removeBread = new RemoveItemCommand(cart, "Bread");

            addBread.Execute(); // "Item Bread added to cart." is printed
            addMilk.Execute(); // "Item Milk added to cart." is printed
            removeBread.Execute(); // "Item Bread removed from cart." is printed

            Console.ReadKey();
        }
    }
}
