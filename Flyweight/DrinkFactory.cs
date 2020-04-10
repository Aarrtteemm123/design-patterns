using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class DrinkFactory
    {
        private static Dictionary<string, Drink> drinkMap = new Dictionary<string, Drink>();

        public static Drink getDrink(String name)
        {
            Drink drink;
            drinkMap.TryGetValue(name, out drink);

            if (drink == null)
            {
                drink = new Drink(name);
                drinkMap.Add(name, drink);
                Console.WriteLine("Creating drink with name : " + name);
            }
            return drink;
        }
    }
}