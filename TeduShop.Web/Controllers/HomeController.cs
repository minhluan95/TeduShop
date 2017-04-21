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
        IProductService _productService;
        public HomeController(IProductCategoryService productCategoryService, ICommonService commonService, IProductService productService)
        {
            _productCategoryService = productCategoryService;
            _commonService = commonService;
            _productService = productService;
        }
        public ActionResult Index()
        {
            var slideModel = _commonService.GetSlide();
            var slideView = Mapper.Map<IEnumerable<Slide>, IEnumerable<SlideViewModel>>(slideModel);

            var lastestProductModel = _productService.GetLastest(6);
            var topSeoProductModel = _productService.GetHotProduct(6);

            var lastestProductView = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(lastestProductModel);
            var topSeoProductView = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(topSeoProductModel);

            var homeViewModel = new HomeViewModel();

            homeViewModel.Slide = slideView;
            homeViewModel.LastestProduct = lastestProductView;
            homeViewModel.TopSeoProduct = topSeoProductView;

            return View(homeViewModel);
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
    }
}