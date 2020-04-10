using System;
using System.Collections.Generic;

namespace Facade
{
    public interface IItem
    {
        float calcPrice(float discount);
        String getNameClass();
        String getName();
        Dictionary<String, int> getProduct();
    }
}