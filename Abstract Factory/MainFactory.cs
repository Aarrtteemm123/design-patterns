namespace Factory
{
    public class MainFactory
    {
        public static MainFactory getFactory(string content)
        {
            if (content == null) return null;
            if (content.Equals("PAGE")) return new PageFactory();
            if (content.Equals("ITEM")) return new ItemFactory();
            return null;
        }
    }
}