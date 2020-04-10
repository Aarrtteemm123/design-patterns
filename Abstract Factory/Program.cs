﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemFactory itemFactory = (ItemFactory)MainFactory.getFactory("ITEM");
            PageFactory pageFactory = (PageFactory)MainFactory.getFactory("PAGE");



            Page galleryPage = pageFactory.getPage("GALLERY_PAGE");
            Page orderPage = pageFactory.getPage("ORDER_PAGE");

            Console.WriteLine(galleryPage.getData());
            Console.WriteLine(orderPage.getData());


            Item pizza = itemFactory.getItem("PIZZA");
            Item drink = itemFactory.getItem("DRINK");

            pizza.setPrice(100);
            drink.setPrice(50);

            Console.WriteLine(pizza.calcDiscount(0.1f));
            Console.WriteLine(drink.calcDiscount(0.5f));
        }
    }
}
