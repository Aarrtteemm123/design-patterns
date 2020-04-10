using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem drink = new Drink();
            IItem discountDrink = new DiscountItemDecorator(new Drink());

            IItem pizza = new Pizza();
            IItem discountPizza = new DiscountItemDecorator(new Pizza());


            Console.WriteLine("Drink with normal price");
            drink.calcPrice(0);

            Console.WriteLine("\nDrink with discount");
            discountDrink.calcPrice(0.4f);

            Console.WriteLine("\nPizza with normal price");
            pizza.calcPrice(0);

            Console.WriteLine("\nPizza with discount");
            discountPizza.calcPrice(0.1f);
        }
    }
}
