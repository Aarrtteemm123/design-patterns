namespace Proxy
{
    public class ProxyPage: IPage
    {
        private CommentPage commentPage;

        public ProxyPage()
        {
        }

        public void display()
        {
            if (commentPage == null)
            {
                commentPage = new CommentPage();
            }
            commentPage.display();
        }
    }
}