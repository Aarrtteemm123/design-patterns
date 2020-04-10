using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Price priceItem = new Price();

            Dictionary<String, int> product = new Dictionary<String, int>();
            product.Add("Bacon", 1);
            product.Add("Cheese", 4);
            product.Add("Mushrooms", 2);
            Pizza pizza = new Pizza("My pizza", product);

            Console.Write(priceItem.getPrice(pizza, 0.1f)+"\n");
        }
    }
}
