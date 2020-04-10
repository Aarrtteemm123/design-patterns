using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Observer
    {
        protected Menu menu;
        public abstract void update();

        public Observer()
        {
        }

        public Menu getMenu()
        {
            return menu;
        }

        public void setMenu(Menu menu)
        {
            this.menu = menu;
        }
    }
}
