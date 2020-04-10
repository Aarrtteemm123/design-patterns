using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OperationCreateCheesePizza : IStrategy
    {
        public Pizza doOperation(float price)
        {
            Console.WriteLine("Create cheese pizza");
            return new Pizza("Cheese", price);
        }
    }
}
