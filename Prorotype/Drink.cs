namespace Prorotype
{
    public class Drink : Item
    {
        private float capacity;

        public Drink(string name, float price, float capacity) : base(name, price)
        {
            this.capacity = capacity;
        }

        public float getCapacity()
        {
            return capacity;
        }

        public void setCapacity(float capacity)
        {
            this.capacity = capacity;
        }

        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }

        public override float calcDiscount(float discount)
        {
            return price * discount;
        }
    }
}