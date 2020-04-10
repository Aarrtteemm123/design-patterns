using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IStrategy
    {
        Pizza doOperation(float price);
    }
}
