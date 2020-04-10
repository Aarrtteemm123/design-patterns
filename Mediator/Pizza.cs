﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pizza:IItem
    {
        private int price;

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public Pizza()
        {
            Random random = new Random();
            this.price = (int)(random.Next(100));
        }

        public void calcPrice()
        {
            Mediator.calcPrice(this);
        }
    }
}
