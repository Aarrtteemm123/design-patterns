using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drinks beer = new Drinks("Beer", 20, 200);

            BuyDrinks buyDrinks = new BuyDrinks(beer);
            SellDrinks sellDrinks = new SellDrinks(beer);

            Broker broker = new Broker();
            broker.takeOrder(buyDrinks);
            broker.takeOrder(sellDrinks);

            broker.trade();
        }
    }
}
