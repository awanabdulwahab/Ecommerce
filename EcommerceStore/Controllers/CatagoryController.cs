using EcommerceClassLibrary;
using EcommerceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceStore.Controllers
{
    public class CatagoryController : Controller
    {
        CatagoriesService catagoryservice = new CatagoriesService();
        // GET: Catagory
        [HttpGet]
        public ActionResult Index()
        {
            var catagories = catagoryservice.GetCatagories();

            return View(catagories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Catagory
        [HttpPost]
        public ActionResult Create(CatagoryModel catagory)
        {
            catagoryservice.SaveCatagory(catagory);
            return View();
        }  
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var catagory = catagoryservice.GetCatagory(id);
            if (catagory == null)
            {
                return new HttpNotFoundResult();
            }
            return View();
        }
        // POST: Catagory
        [HttpPost]
        public ActionResult Edit(CatagoryModel catagory)
        {
            catagoryservice.UpdateeCatagory(catagory);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var catagory = catagoryservice.GetCatagory(id);
            if (catagory == null)
            {
                return new HttpNotFoundResult();
            }
            return View();
        }
        // POST: Catagory
        [HttpPost]
        public ActionResult Delete (CatagoryModel catagory)
        {
            catagoryservice.DeleteCatagory(catagory.id);
            return RedirectToAction("Index");
        }
    }
}