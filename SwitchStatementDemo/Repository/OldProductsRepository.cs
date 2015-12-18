using System.Collections.Generic;
using System.Linq;
using SwitchStatementDemo.Models;

namespace SwitchStatementDemo.Repository
{
    public class OldProductsRepository
    {
        private List<Product> _products = FakeProductList.GetProducts();

        private IEnumerable<Product> GetAll()
        {
            return _products;
        } 

        public IEnumerable<Product> GetResults(ListType type)
        {
            IEnumerable<Product> results = null;
            switch (type)
            {
                case ListType.SearchResults:
                    results = GetSearchResults();
                    break;
                case ListType.Favorites:
                    results = GetFavorites();
                    break;
                case ListType.WishList:
                    results = GetWishList();
                    break;
            }
            return results;
        }

        private IEnumerable<Product> GetWishList()
        {
            return _products.Where(e => e.ListType == ListType.WishList);
        }

        private IEnumerable<Product> GetFavorites()
        {
            return _products.Where(e => e.ListType == ListType.Favorites);
        }

        private IEnumerable<Product> GetSearchResults()
        {
            return GetAll();
        }

    }
}