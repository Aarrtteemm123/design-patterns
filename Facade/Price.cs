using System;

namespace Facade
{
    public class Price
    {
        public float getPrice(IItem item, float discount)
        {
            if (item.getNameClass().Equals("Pizza"))
            {
                String[] nameProducts = { "Onion", "Tomato", "Meat", "Bacon", "Cheese", "Parsley" };
                float[] priceProducts = { 5, 10, 50, 12, 32, 8 };
                float price = 0;
                for (int i = 0; i < nameProducts.Length; i++)
                {
                    try
                    {
                        price += item.getProduct()[nameProducts[i]] * priceProducts[i];
                    }
                    catch (Exception e)
                    {
                        // product not found;
                    }
                }
                return price * (1 - discount);
            }
            else
                return item.calcPrice(discount);
        }
    }
}