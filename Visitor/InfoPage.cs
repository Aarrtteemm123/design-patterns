using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InfoPage : ISitePart
    {
        private String name;

        public InfoPage(String name)
        {
            this.name = name;
        }

        public InfoPage()
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
