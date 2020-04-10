using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbstractManager
    {
        protected String[] pizzaNames = new String[3] {"4 cheese", "Paprika", "Vegan"};
        protected String[] drinksNames = new String[3] {"Water", "Pepsi", "Sprite"};
        protected String[] orderNames = new String[3] {"ID 001", "ID 002", "ID 003"};

        protected AbstractManager nextManager;
        public abstract void check(String type, String name);

        public AbstractManager()
        {
        }

        public void setNextManager(AbstractManager nextManager)
        {
            this.nextManager = nextManager;
        }
    }
}