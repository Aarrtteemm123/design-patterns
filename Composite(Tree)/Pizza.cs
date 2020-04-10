using System;
using System.Collections.Generic;

namespace Composite_Tree_
{
    public class Pizza : IItem
    {
        private String name;
        private float price;
        private Dictionary<String, int> product;

        public Pizza(String name)
        {
            this.name = name;
        }

        public Pizza()
        {
        }

        public Pizza(String name, float price, Dictionary<String, int> product)
        {
            this.name = name;
            this.price = price;
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

        public float calcPrice(float discount)
        {
            return price * discount;
        }


        public String toString()
        {
            return name;
        }

        public String getNameClass()
        {
            return "Pizza";
        }

        public String getDetail()
        {
            String str = "{ ";
            foreach (KeyValuePair<String, int> keyValue in product)
            {
                str += (keyValue.Key + " = " + keyValue.Value + " ");
            }

            return str + " }";
        }
    }
}