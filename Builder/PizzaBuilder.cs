using System;
using System.Collections.Generic;

namespace Builder
{
    public class PizzaBuilder : IBulder
    {
        private Dictionary<String, int> product = new Dictionary<String, int>();

        public void reset()
        {
            product = new Dictionary<String,int>();
        }

        public void setTomato(int number)
        {
            product.Add("Tomato", number);
        }

       
        public void setMushrooms(int number)
        {
            product.Add("Mushrooms", number);
        }

     
        public void setCheese(int number)
        {
            product.Add("Cheese", number);
        }


        public void setOnion(int number)
        {
            product.Add("Onion", number);
        }


        public void setBacon(int number)
        {
            product.Add("Bacon", number);
        }


        public void setParsley(int number)
        {
            product.Add("Parsley", number);
        }


        public void setMeat(int number)
        {
            product.Add("Meat", number);
        }


        public Pizza getResult()
        {
            return new Pizza(product);
        }
    }
}