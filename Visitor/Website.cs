using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Website : ISitePart
    {
        private ISitePart[] siteParts;
        private String name;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Website()
        {
        }

        public Website(String name)
        {
            this.name = name;
            siteParts = new ISitePart[] {new MainPage("Main"),
                new GalleryPage("Gallery"),
                new InfoPage("Additional Information")};
        }
        public void accept(ISitePartVisitor sitePartVisitor)
        {
            for (int i = 0; i < siteParts.Length; i++)
            {
                siteParts[i].accept(sitePartVisitor);
            }
            sitePartVisitor.visit(this);
        }
    }
}
