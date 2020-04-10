using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pizza : Observer
    {
        private String name;
        private float price;
        private Menu menu;

        public Pizza(String name, float price, Menu menu)
        {
            this.name = name;
            this.price = price;
            this.menu = menu;
            this.menu.attach(this);
        }

        public Pizza()
        {
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }


        public override void update()
        {
            price *= (1 - menu.getDiscount());
            Console.WriteLine("Price updated,new price " + price);
        }
    }
}