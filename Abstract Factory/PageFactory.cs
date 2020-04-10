namespace Factory
{
    public class PageFactory:MainFactory
    {
        public Page getPage(string pageType)
        {
            if (pageType == null) return null;
            if (pageType.Equals("GALLERY_PAGE")) return new GalleryPage();
            if (pageType.Equals("ORDER_PAGE")) return new OrderPage();
            return null;
        }
    }
}