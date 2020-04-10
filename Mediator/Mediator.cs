using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mediator
    {
        private static int price = 0;
        public static void calcPrice(Pizza pizza)
        {
            price += pizza.getPrice();
            Console.WriteLine("Price: " + price);
        }
        public static void calcPrice(Drink drink)
        {
            price += drink.getPrice();
            Console.WriteLine("Price: " + price);
        }
    }
}
