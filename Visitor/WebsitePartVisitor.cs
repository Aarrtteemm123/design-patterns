using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WebsitePartVisitor : ISitePartVisitor
    {
        public void visit(MainPage mainPage)
        {
            Console.WriteLine("Visit " + mainPage.getName() + " page");
        }

        public void visit(GalleryPage galleryPage)
        {
            Console.WriteLine("Visit " + galleryPage.getName() + " page");
        }

        public void visit(InfoPage infoPage)
        {
            Console.WriteLine("Visit " + infoPage.getName() + " page");
        }

        public void visit(Website website)
        {
            Console.WriteLine("Visit website " + website.getName());
        }
    }
}
