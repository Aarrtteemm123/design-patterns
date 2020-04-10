using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Pizza
    {
        private String name;
        private float price;
        private Dictionary<String, int> product;

        public Pizza()
        {
        }

        public Pizza(String name, float price, Dictionary<String, int> product)
        {
            this.name = name;
            this.price = price;
            this.product = product;
        }

        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.Write("Product: ");
            showPizza();
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

        public void showPizza()
        {
            Console.Write("{ ");
            foreach (KeyValuePair<String, int> keyValue in product)
            {
                Console.Write(keyValue.Key + " = " + keyValue.Value + " ");
            }
            Console.WriteLine("}");
        }

        public String getDetail()
        {
            String str = "{ ";
            foreach (KeyValuePair<String, int> keyValue in product)
            {
                str+=(keyValue.Key + " = " + keyValue.Value + " ");
            }

            return str+" }";
        }
    }
}