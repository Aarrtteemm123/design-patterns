using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VipClient : Order
    {
        private Dictionary<string, float> items;
        private String numberCard;
        private int priority;

        public Dictionary<string, float> getItems()
        {
            return items;
        }

        public void setItems(Dictionary<string, float> items)
        {
            this.items = items;
        }

        public String getNumberCard()
        {
            return numberCard;
        }

        public void setNumberCard(String numberCard)
        {
            this.numberCard = numberCard;
        }

        public int getPriority()
        {
            return priority;
        }

        public void setPriority(int priority)
        {
            this.priority = priority;
        }

        public VipClient(String numberCard, int priority)
        {
            this.numberCard = numberCard;
            this.priority = priority;
        }

        bool checkCard()
        {
            Console.WriteLine("Checking vip cart...");
            return true;
        }


        public override void createOrder(Dictionary<string, float> items)
        {
            Console.WriteLine("Create order");
            if (checkCard())
                this.items = items;
            else
                Console.WriteLine("Card can not found");
        }


        public override void executeOrder()
        {
            Console.WriteLine("Execute order with " + priority + " priority");
        }


        public override void fihishOrder()
        {
            Console.WriteLine("Save order in VipClient DB");
        }
    }
}
