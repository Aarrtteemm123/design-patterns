namespace Prorotype
{
    public class Pizza : Item
    {
        private float size;
        private string image;

        public Pizza(string name, float price, float size, string image) : base(name, price)
        {
            this.size = size;
            this.image = image;
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