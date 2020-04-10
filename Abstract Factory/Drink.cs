namespace Factory
{
    public class Drink : Item
    {
        private float capacity;

        public Drink()
        {

        }

        public Drink(string name, float price, float capacity) : base(name, price)
        {
            this.capacity = capacity;
        }

        public override float calcDiscount(float discount)
        {
            return price * discount;
        }
    }
}