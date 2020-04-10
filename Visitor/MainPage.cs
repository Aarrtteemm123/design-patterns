using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainPage : ISitePart
    {
        private String name;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public MainPage(String name)
        {
            this.name = name;
        }

        public MainPage()
        {
        }
        public void accept(ISitePartVisitor sitePartVisitor)
        {
            sitePartVisitor.visit(this);
        }
    }
}
