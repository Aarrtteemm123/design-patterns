using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GalleryPage : ISitePart
    {
        private String name;

        public GalleryPage(String name)
        {
            this.name = name;
        }

        public GalleryPage()
        {
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void accept(ISitePartVisitor sitePartVisitor)
        {
            sitePartVisitor.visit(this);
        }
    }
}
