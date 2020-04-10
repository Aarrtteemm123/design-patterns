using System;
using System.Collections.Generic;

namespace Bridge
{
    public class MeatPizza : IOrder
    {
        private String name;
        private float price;
        private Dictionary<String, int> product;

        public MeatPizza()
        {
            name = "Meat";
            product = new Dictionary<String, int>();
            product.Add("Bacon", 4);
            product.Add("Meat", 2);
            product.Add("Cheese", 3);
            product.Add("Mushrooms", 2);
        }

        public MeatPizza(Dictionary<String, int> product)
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
            Console.WriteLine("Meat pizza adding to order...");
        }

    }
}