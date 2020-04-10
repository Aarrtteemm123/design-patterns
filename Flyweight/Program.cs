using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new String[5] { "Cola", "Pepsi", "Bear", "Water", "Sprite" };
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Drink drink = DrinkFactory.getDrink(names[i % names.Length]);
                drink.setPrice((float)(rand.Next(100)));
                drink.setCapacity((float)(rand.Next(10)));
                Console.WriteLine(drink.getName() + ": " + drink.getPrice());
            }
        }
    }
}
