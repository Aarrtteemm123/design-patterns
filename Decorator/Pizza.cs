using System;

namespace Decorator
{
    public class Pizza: IItem
    {
        private String name;
        private float price;

        public Pizza(String name)
        {
            this.name = name;
        }

        public Pizza()
        {
        }

        public Pizza(String name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public float calcPrice(float discount)
        {
            return price * discount;
        }


        public String getNameClass()
        {
            return "Pizza";
        }
    }
}