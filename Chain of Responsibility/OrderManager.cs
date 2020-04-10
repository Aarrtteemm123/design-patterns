using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderManager: AbstractManager
    {
        public override void check(string type, string name)
        {
            if (type == ("order"))
            {
                for (int i = 0; i < orderNames.Length; i++)
                {
                    if (name == (orderNames[i]))
                        Console.WriteLine("Checking order successfully complete");
                }
            }
            else Console.WriteLine("It's not order");
            if (nextManager != null)
                nextManager.check(type, name);
        }
    }
}
