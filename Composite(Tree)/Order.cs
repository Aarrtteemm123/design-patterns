using System.Collections.Generic;

namespace Composite_Tree_
{
    public class Order
    {
        private List<IItem> items;

        public List<IItem> getItems()
        {
            return items;
        }

        public void setItems(List<IItem> items)
        {
            this.items = items;
        }

        public Order()
        {
            items = new List<IItem>();
        }

        public void addToOrder(IItem item)
        {
            items.Add(item);
        }
    }
}