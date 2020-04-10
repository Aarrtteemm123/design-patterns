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
            Context context = new Context();
            context.pizza = new Pizza("Pizza_1", 45);

            ApplyDiscount applyDiscount = new ApplyDiscount(0.2f);
            applyDiscount.doAction(context);

            Console.WriteLine(context.getState().ToString());

            RemovePizza removeOrder = new RemovePizza();
            removeOrder.doAction(context);

            Console.WriteLine(context.getState().ToString());
        }
    }
}
