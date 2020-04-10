using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Item veganPizza = new Pizza(new VeganPizza());
            Item meatPizza = new Pizza(new MeatPizza());

            veganPizza.selectItem();
            meatPizza.selectItem();

        }
    }
}
