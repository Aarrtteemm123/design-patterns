namespace Factory
{
    public class ItemFactory:MainFactory
    {
        public Item getItem(string itemType)
        {
            if (itemType == null) return null;
            if (itemType.Equals("PIZZA")) return new Pizza();
            if (itemType.Equals("DRINK")) return new Drink();
            return null;
        }
    }
}