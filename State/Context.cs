using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Context
    {
        private IState state;
        public Pizza pizza;

        public Context()
        {
            state = null;
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getState()
        {
            return state;
        }
    }
}
