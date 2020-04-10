using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BuyDrinks:IOrder
    {
        private Drinks drink;

        public BuyDrinks(Drinks drink)
        {
            this.drink = drink;
        }
        public void execute(int liters)
        {
            drink.buy(liters);
        }
    }
}
