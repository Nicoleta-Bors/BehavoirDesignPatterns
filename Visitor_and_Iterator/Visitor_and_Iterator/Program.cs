using System;
using System.Collections.Generic;

namespace Visitor_and_Iterator
{

    class Program
    {
        static void Main()
        {
            var order = new Order();

            // Se adauga produse la comanda
            order.AddProduct(new Product("Pizza Margherita", 25));
            order.AddProduct(new Product("Burger", 15));
            order.AddProduct(new Product("Cola", 5));

            var orderVisitor = new OrderVisitor();
            decimal totalPrice = order.Accept(orderVisitor);

            // Se afiseaza comanda si pretul total
            Console.WriteLine("Comanda:");
            foreach (var product in order.GetProducts())
            {
                Console.WriteLine($"{product.Name} - {product.Price} lei");
            }
            Console.WriteLine($"Pret total: {totalPrice} lei");

        }
    }
}