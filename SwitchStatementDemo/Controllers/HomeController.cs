using System.Web.Mvc;
using SwitchStatementDemo.Models;
using SwitchStatementDemo.Repository;
using SwitchStatementDemo.ViewModel;

namespace SwitchStatementDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly OldProductsRepository _repository = new OldProductsRepository();

        public ActionResult Index()
        {
            return View();
        }

        #region Old way

        //public ActionResult Favorites()
        //{
        //    // Old way
        //    var model = new ProductViewModel
        //    {
        //        Products = _repository.GetResults(ListType.Favorites)
        //    };

        //    return View(model);
        //}

        //public ActionResult WishList()
        //{
        //    // Old way
        //    var model = new ProductViewModel
        //    {
        //        Products = _repository.GetResults(ListType.WishList)
        //    };

        //    return View(model);
        //}

        //public ActionResult SearchResults()
        //{
        //    // Old way
        //    var model = new ProductViewModel
        //    {
        //        Products = _repository.GetResults(ListType.SearchResults)
        //    };

        //    return View(model);
        //}

        #endregion

        #region New Way

        public ActionResult Favorites()
        {
            var records = new FavoritesList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams { PageIndex = 1, PageSize = 20 })
            };

            return View(model);
        }

        public ActionResult WishList()
        {
            var records = new WishList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams { PageIndex = 1, PageSize = 20 })
            };

            return View(model);
        }

        public ActionResult SearchResults()
        {
            var records = new SearchResultList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams { PageIndex = 1, PageSize = 20 })
            };

            return View(model);
        }

        #endregion

    }
}