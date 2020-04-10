using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorotype
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("four cheese", 45, 30, "path to image");
            Pizza newPizza = (Pizza) pizza.Clone();
            Console.WriteLine("Item : " + newPizza.getName());

            Drink drink = new Drink("fanta", 50, 0.5f);
            Drink newDrink = (Drink) drink.Clone();
            Console.WriteLine("Item : " + newDrink.getName());
        }
    }
}