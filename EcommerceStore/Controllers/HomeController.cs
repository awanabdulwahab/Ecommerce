using EcommerceServices;
using EcommerceStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceStore.Controllers
{
    public class HomeController : Controller
    {
        CatagoriesService catagoriesService = new CatagoriesService();
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.FeatureCatagories = catagoriesService.GetFeatureCatagories();
            return View(model);
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
    }
}