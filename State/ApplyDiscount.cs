using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ApplyDiscount : IState
    {
        private float discount;

        public ApplyDiscount(float discount)
        {
            this.discount = discount;
        }

        
        public override String ToString()
        {
            return "State: ApplyDiscount";
        }

        public void doAction(Context context)
        {
            if (context.pizza != null)
            {
                Console.WriteLine("Apply discount...");
                float oldPrice = context.pizza.getPrice();
                context.pizza.setPrice(oldPrice * discount);
                context.setState(this);
            }
        }
    }
}
