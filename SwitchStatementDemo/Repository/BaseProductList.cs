using System.Collections.Generic;
using SwitchStatementDemo.Models;

namespace SwitchStatementDemo.Repository
{
    /// <summary>
    /// New Strategy class for pulling records, but different types of records.
    /// </summary>
    public abstract class BaseProductList
    {
        protected IEnumerable<Product> _products = FakeProductList.GetProducts();

        public virtual IEnumerable<Product> GetResults(ListParams parameters)
        {
            return null;
        }
    }
}