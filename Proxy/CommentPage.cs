using System;

namespace Proxy
{
    public class CommentPage: IPage
    {
        String name;

        public CommentPage()
        {
            loadData();
        }

        public void loadData()
        {
            Console.WriteLine("Loading data...");
        }
        public void display()
        {
            Console.WriteLine("Page display");
        }
    }
}