namespace Factory
{
    public class Pizza : Item
    {
        private float size;
        private string image;

        public Pizza()
        {

        }

        public Pizza(string name, float price, float size, string image) : base(name, price)
        {
            this.size = size;
            this.image = image;
        }

        public override float calcDiscount(float discount)
        {
            return price * discount;
        }
    }
}