using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static AbstractManager getChainOfManager()
        {

            AbstractManager pizzaManager = new PizzaManager();
            AbstractManager drinksManager = new DrinksManager();
            AbstractManager orderManager = new OrderManager();

            pizzaManager.setNextManager(drinksManager);
            drinksManager.setNextManager(orderManager);

            return pizzaManager;
        }
        static void Main(string[] args)
        {
            AbstractManager manager = getChainOfManager();
            manager.check("pizza", "Paprika");
            Console.WriteLine("----------------------");
            manager.check("drinks", "Water");
            Console.WriteLine("----------------------");
            manager.check("order", "ID 001");
        }
    }
}
