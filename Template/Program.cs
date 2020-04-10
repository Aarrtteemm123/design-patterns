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
            Dictionary<string, float> items = new Dictionary<string, float>() {
                    {"Pizza_1", 50f},
                    { "Cola", 12f}
            };

            Order order = new Client();
            order.start(items);

            Console.WriteLine("\n");

            order = new VipClient("46132146513",1);
            order.start(items);
        }
    }
}
