using System;
using System.Collections.Generic;

namespace Composite_Tree_
{
    public class Drink : IItem
    {
        private String name;
        private float price;
        private float capacity;

        public Drink()
        {
        }

        public Drink(String name)
        {
            this.name = name;
        }

        public Drink(String name, float price, float capacity)
        {
            this.name = name;
            this.price = price;
            this.capacity = capacity;
        }

        public String getName()
        {
            return name;
        }

        public Dictionary<String, int> getProduct()
        {
            return null;
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

        public float getCapacity()
        {
            return capacity;
        }

        public void setCapacity(float capacity)
        {
            this.capacity = capacity;
        }

        public float calcPrice(float discount)
        {
            return price * discount;
        }

        public  String toString()
        {
            return name;
        }

        public String getNameClass()
        {
            return "Drink";
        }

        public String getDetail()
        {
            return name + " " + price;
        }
    }
}