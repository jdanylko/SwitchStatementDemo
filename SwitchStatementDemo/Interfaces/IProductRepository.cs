using System.Collections.Generic;
using SwitchStatementDemo.Models;

namespace SwitchStatementDemo.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetSearchItems(ListParams parms);
        IEnumerable<Product> GetFavoriteProducts(ListParams parms);
        IEnumerable<Product> GetWishList(ListParams parms);
        IEnumerable<Product> GetChristmasList(ListParams parms);
    }
}