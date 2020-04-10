using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Tree_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();

            order.addToOrder(new Drink("Water"));
            order.addToOrder(new Drink("Orange juice"));

            Dictionary<String, int> product = new Dictionary<String, int>();
            product.Add("Bacon", 1);
            product.Add("Cheese", 4);
            product.Add("Mushrooms", 2);
            order.addToOrder(new Pizza("Four cheese", 125, product));

            orders.Add(order);

            for (int j = 0; j < orders.Count; j++)
            {
                Console.WriteLine("Id: " + 1);
                for (int i = 0; i < order.getItems().Count; i++)
                {
                    if (order.getItems()[i].getNameClass().Equals("Pizza"))
                    {
                        Console.WriteLine(order.getItems()[i].getNameClass()
                                           + ": " + order.getItems()[i].getName() +
                                           "  " + order.getItems()[i].getDetail());
                    }
                    else
                        Console.WriteLine(order.getItems()[i].getNameClass() +
                                           ": " + order.getItems()[i].getName());
                }
            }
        }
    }
}
