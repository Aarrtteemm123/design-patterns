using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PizzaView
    {
        private String name;
        private float price;
        private String pathToPhoto;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public String getPathToPhoto()
        {
            return pathToPhoto;
        }

        public void setPathToPhoto(String pathToPhoto)
        {
            this.pathToPhoto = pathToPhoto;
        }

        public PizzaView()
        {
        }

        public PizzaView(String name, float price, String pathToPhoto)
        {
            this.name = name;
            this.price = price;
            this.pathToPhoto = pathToPhoto;
        }

        public void viewPizza()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Price " + price);
            Console.WriteLine("Loading image...");
        }
    }
}
