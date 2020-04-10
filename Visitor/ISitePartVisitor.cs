using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ISitePartVisitor
    {
        void visit(MainPage mainPage);
        void visit(GalleryPage galleryPage);
        void visit(InfoPage infoPage);
        void visit(Website website);
    }
}
