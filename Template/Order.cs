using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Order
    {
        public abstract void createOrder(Dictionary<string, float> items);
        public abstract void executeOrder();
        public abstract void fihishOrder();

        //template method
        public void start(Dictionary<string, float> items)
        {
            createOrder(items);
            executeOrder();
            fihishOrder();
        }
    }
}