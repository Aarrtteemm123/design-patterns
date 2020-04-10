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
            Pizza pizza = new Pizza();
            Drink drink = new Drink();
            pizza.calcPrice();
            drink.calcPrice();
        }
    }
}
