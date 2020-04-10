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
            Context context = new Context(new OperationCreateVeganPizza());
            Pizza pizza = context.executeStrategy(40);
            Console.WriteLine(pizza.getName());

            context = new Context(new OperationCreateMeatPizza());
            pizza = context.executeStrategy(90);
            Console.WriteLine(pizza.getName());

            context = new Context(new OperationCreateCheesePizza());
            pizza = context.executeStrategy(68);
            Console.WriteLine(pizza.getName());
        }
    }
}
