using System;

namespace Decorator
{
    public class DiscountItemDecorator: ItemDecorator
    {
       
        public override float calcPrice(float discount)
        {
            Console.WriteLine("Item with discount: " + discount);
            return decoratedItem.calcPrice(discount);
        }

        public DiscountItemDecorator(IItem decoratedItem) : base(decoratedItem)
        {
            base.decoratedItem = decoratedItem;
        }
    }
}