namespace Adapter
{
    public class Adapter
    {
        public Item toItem(Pizza pizza)
        {
            int discount = 0;
            Item item = new Item(pizza.getName(), pizza.getPrice(),
                pizza.getDetail(), discount);
            return item;
        }
    }
}