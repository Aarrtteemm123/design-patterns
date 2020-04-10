using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Drinks : IContainer
    {
        private static String[] drinks = new String[]{ "Water", "Cola", "Tea", "Coffee" };
        public IIterator getIterator()
        {
            return new drinksIterator();
        }

        private class drinksIterator : IIterator
        {
            int index;

            public bool hasNext()
            {
                return index < drinks.Length;
            }

            public Object next()
            {
                if (this.hasNext())
                {
                    return drinks[index++];
                }

                return null;
            }
        }
    }
}