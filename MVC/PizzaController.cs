using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PizzaController
    {
        private Pizza modelPizza;
        private PizzaView viewPizza;

        public PizzaController(Pizza modelPizza, PizzaView viewPizza)
        {
            this.modelPizza = modelPizza;
            this.viewPizza = viewPizza;
        }

        public void setPizzaName(String name)
        {
            modelPizza.setName(name);
        }

        public String getPizzaName()
        {
            return modelPizza.getName();
        }

        public void setPizzaPrice(float newPrice)
        {
            modelPizza.setPrice(newPrice);
        }

        public float getPizzaPrice()
        {
            return modelPizza.getPrice();
        }

        public void updateView()
        {
            viewPizza.setName(modelPizza.getName());
            viewPizza.setPrice(modelPizza.getPrice());
            viewPizza.viewPizza();
        }
    }
}
