namespace Bridge
{
    public abstract class Item
    {
        protected IOrder order;

        public Item()
        {
        }

        protected Item(IOrder order)
        {
            this.order = order;
        }
        public abstract void selectItem();

    }
}