using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RemovePizza : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Remove pizza...");
            context.pizza = null;
            context.setState(this);
        }
        public override String ToString()
        {
            return "State: RemovePizza";
        }
    }
}
