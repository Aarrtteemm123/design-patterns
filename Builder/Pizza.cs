using System;
using System.Collections.Generic;

namespace Builder
{
    public class Pizza
    {
        private String name;
        private float price;
        private Dictionary<String, int> product;

        public Pizza()
        {
        }

        public Pizza(Dictionary<String, int> product)
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

        public void show()
        {
            Console.Write("{ ");
            foreach (KeyValuePair<String, int> keyValue in product)
            {
                Console.Write(keyValue.Key + " = " + keyValue.Value+" ");
            }
            Console.WriteLine("}");
        }

        public void setProduct(String key, int value)
        {
            this.product.Add(key, value);
        }
    }
}