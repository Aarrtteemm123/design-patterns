using System;
using System.Collections.Generic;

namespace Bridge
{
    public class VeganPizza : IOrder
    {
        private String name;
        private float price;
        private Dictionary<String, int> product;

        public VeganPizza()
        {
            name = "Vegan";
            product = new Dictionary<String, int>();
            product.Add("Tomato", 1);
            product.Add("Onion", 2);
            product.Add("Parsley", 3);
            product.Add("Cucumber", 2);
        }

        public VeganPizza(Dictionary<String, int> product)
        {
            this.name = "name";
            this.price = 0;
            this.product = product;
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

        public void setPrice(float price)
        {
            this.price = price;
        }

        public Dictionary<String, int> getProduct()
        {
            return product;
        }

        public void setProduct(String key, int value)
        {
            this.product.Add(key, value);
        }


        public void addToOrder()
        {
            Console.WriteLine("Vegan pizza adding to order...");
        }
    }
}