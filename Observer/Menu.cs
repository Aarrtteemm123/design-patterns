using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        private List<Observer> observers = new List<Observer>();
        private float discount;

        public float getDiscount()
        {
            return discount;
        }

        public void setDiscount(float discount)
        {
            this.discount = discount;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
    }
}
