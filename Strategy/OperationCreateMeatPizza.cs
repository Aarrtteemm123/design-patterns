using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OperationCreateMeatPizza : IStrategy
    {
        public Pizza doOperation(float price)
        {
            Console.WriteLine("Create meat pizza");
            return new Pizza("Meat", price);
        }
    }
}
