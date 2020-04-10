using System;
using System.Collections.Generic;

namespace Composite_Tree_
{
    public interface IItem
    {
        float calcPrice(float discount);
        String getNameClass();
        String getName();
        String getDetail();
        Dictionary<String, int> getProduct();
    }
}