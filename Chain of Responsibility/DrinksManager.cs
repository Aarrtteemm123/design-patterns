using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DrinksManager : AbstractManager
    {
        public override void check(string type, string name)
        {
            if (type==("drinks"))
            {
                for (int i = 0; i < drinksNames.Length; i++)
                {
                    if (name==(drinksNames[i]))
                        Console.WriteLine("Checking drinks successfully complete");
                }
            }
            else Console.WriteLine("It's not drinks");
            if (nextManager != null)
                nextManager.check(type, name);
        }
    }
}
