using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PizzaManager:AbstractManager
    {
        public override void check(string type, string name)
        {
            if (type == ("pizza"))
            {
                for (int i = 0; i < pizzaNames.Length; i++)
                {
                    if (name == (pizzaNames[i]))
                        Console.WriteLine("Checking pizza successfully complete");
                }
            }
            else Console.WriteLine("It's not pizza");
            if (nextManager != null)
                nextManager.check(type, name);
        }
    }
}
