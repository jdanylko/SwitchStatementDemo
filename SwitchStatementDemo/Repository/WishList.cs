﻿using System.Collections.Generic;
using System.Linq;
using SwitchStatementDemo.Models;

namespace SwitchStatementDemo.Repository
{
    public class WishList : BaseProductList
    {
        public override IEnumerable<Product> GetResults(ListParams parameters)
        {
            // Apply parameters here if you want.
            // or call a stored procedure to retrieve the results.
            return _products.Where(e=> e.ListType == ListType.WishList);
        }
    }
}