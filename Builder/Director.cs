using System;

namespace Builder
{
    public class Director
    {
        IBulder bulder;

        public Director(IBulder bulder)
        {
            this.bulder = bulder;
        }

        public IBulder getBulder()
        {
            return bulder;
        }

        public void createPizza(String type)
        {
            bulder = new PizzaBuilder();
            switch (type)
            {
                case "Vegan":
                {
                    bulder.setParsley(3);
                    bulder.setOnion(2);
                    bulder.setCheese(1);
                    bulder.setTomato(2);
                    break;
                }

                case "Meat":
                {
                    bulder.setBacon(4);
                    bulder.setMeat(2);
                    bulder.setMushrooms(1);
                    break;
                }
            }
        }
    }
}