namespace Decorator
{
    public abstract class ItemDecorator: IItem
    {
        protected IItem decoratedItem;

        public ItemDecorator(IItem decoratedItem)
        {
            this.decoratedItem = decoratedItem;
        }

        public virtual float calcPrice(float discount)
        {
            return decoratedItem.calcPrice(discount);
        }
    }
}