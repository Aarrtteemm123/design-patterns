using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : Order
    {
        private Dictionary<string, float> items;

        public Client()
        {
        }

        public Dictionary<string, float> getItems()
        {
            return items;
        }

        public void setItems(Dictionary<string, float> items)
        {
            this.items = items;
        }

     
        public override void createOrder(Dictionary<string, float> items)
        {
            Console.WriteLine("Create order");
            this.items = items;
        }


        public override void executeOrder()
        {
            Console.WriteLine("Check items");
        }


        public override void fihishOrder()
        {
            Console.WriteLine("Save in DB");
        }
    }
}
