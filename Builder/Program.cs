using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director boss = new Director(new PizzaBuilder());
            boss.createPizza("Vegan");
            Pizza pizza = boss.getBulder().getResult();
            pizza.show();
        }
    }
}
