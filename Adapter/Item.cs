using System;

namespace Adapter
{
    public class Item
    {
        private String name;
        private double price;
        private String detail;
        private int discount;

        public Item()
        {
        }

        public Item(String name, double price, String detail, int discount)
        {
            this.name = name;
            this.price = price;
            this.detail = detail;
            this.discount = discount;
        }

        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Detail: " + detail);
            Console.WriteLine("Discount: " + discount);
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getDiscount()
        {
            return discount;
        }

        public void setDiscount(int discount)
        {
            this.discount = discount;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }

        public String getDetail()
        {
            return detail;
        }

        public void setDetail(String detail)
        {
            this.detail = detail;
        }
    }
}