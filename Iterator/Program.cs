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
            Drinks drinks = new Drinks();

            for (IIterator iter = drinks.getIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
