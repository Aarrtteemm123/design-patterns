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
            Menu menu = new Menu();
            new Pizza("pizza1", 45, menu);
            new Pizza("pizza2", 30, menu);
            new Drink("drink1", 10, menu);
            new Drink("drink2", 13, menu);

            Console.WriteLine("Original price\n");
            menu.setDiscount(0);
            Console.WriteLine("\nPrice with discount\n");
            menu.setDiscount(0.2f);
        }
    }
}
