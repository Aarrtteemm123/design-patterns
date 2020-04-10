using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> product = new Dictionary<string, int>();
            product.Add("Tomato", 5);
            product.Add("Onion", 1);
            product.Add("Bacon", 3);

            Pizza pizza = new Pizza("My pizza", 45, product);
            pizza.show();
            Console.WriteLine("\n");
            Item item = new Adapter().toItem(pizza);
            item.show();
        }
    }
}
