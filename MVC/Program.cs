using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza model = new Pizza("Pizza_1", 43f);
            PizzaView view = new PizzaView(model.getName(), model.getPrice(),
                "image/pizza/1");
            PizzaController pizzaController = new PizzaController(model, view);
            pizzaController.updateView();
            pizzaController.setPizzaName("Pizza_2");
            pizzaController.setPizzaPrice(66);
            pizzaController.updateView();
        }
    }
}
