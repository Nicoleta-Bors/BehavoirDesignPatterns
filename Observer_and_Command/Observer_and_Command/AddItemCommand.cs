using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_and_Command
{

    public class AddItemCommand : ICommand
    {
        private ShoppingCart cart;
        private string item;

        public AddItemCommand(ShoppingCart cart, string item)
        {
            this.cart = cart;
            this.item = item;
        }

        public void Execute()
        {
            cart.AddItem(item);
        }

        public void Undo()
        {
            cart.RemoveItem(item);
        }
    }
}
