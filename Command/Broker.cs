using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void takeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void trade()
        {
            foreach (var order in orderList)
            {
                Random random = new Random();
                order.execute( (random.Next(0, 100)));
            }

            orderList.Clear();
        }
    }
}