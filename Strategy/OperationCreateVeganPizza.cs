using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OperationCreateVeganPizza : IStrategy
    {
        public Pizza doOperation(float price)
        {
            Console.WriteLine("Create vegan pizza");
            return new Pizza("Vegan", price);
        }
    }
}
