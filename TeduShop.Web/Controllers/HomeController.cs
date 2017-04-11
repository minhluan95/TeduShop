using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Models;

namespace TeduShop.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryService _productCategoryService;
        ICommonService _commonService;
        public HomeController(IProductCategoryService productCategoryService, ICommonService commonService)
        {
            _productCategoryService = productCategoryService;
            _commonService = commonService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult HeaderPartial()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult FooterPartial()
        {
            var model = _commonService.GetFooter();
            var footer = Mapper.Map<Footer, FooterViewModel>(model);
            return PartialView(footer);
        }
        [ChildActionOnly]
        public ActionResult CategoryPartial()
        {
            var model = _productCategoryService.GetAll();

            var listProductCategory = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);

            return PartialView(listProductCategory);
        }
        [ChildActionOnly]
        public ActionResult BannerPartial()
        {
            return PartialView();
        }
    }
}