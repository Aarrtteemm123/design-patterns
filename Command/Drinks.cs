using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Drinks
    {
        private String name;
        private int price;
        private int liters;

        public Drinks(String name, int price, int liters)
        {
            this.name = name;
            this.price = price;
            this.liters = liters;
        }

        public void buy(int liters)
        {
            Console.WriteLine(liters + " liters bought");
            this.liters += liters;
        }

        public void sell(int liters)
        {
            Console.WriteLine(liters + " liters sold");
            if (this.liters - liters < 0) this.liters = 0;
            else this.liters -= liters;
        }
    }
}
