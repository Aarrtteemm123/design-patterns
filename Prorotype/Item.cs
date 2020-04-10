namespace Prorotype
{
    public abstract class Item
    {
        protected string name;
        protected float price;

        protected Item(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract Item Clone();
        public string getName()
        {
            return name;
        }

        public void setName(string name)
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

        public abstract float calcDiscount(float discount);
    }
}