using System;

namespace Singleton
{
    public class GalleryPage
    {
        private static GalleryPage instance = new GalleryPage();

        //make the constructor private so that this class cannot be
        //instantiated
        private GalleryPage() { }

        //Get the only object available
        public static GalleryPage getInstance()
        {
            return instance;
        }

        public void toMainPage()
        {
            Console.WriteLine("Go to main page");
        }

        public void toOrderPage()
        {
            Console.WriteLine("Go to order page");
        }
    }
}