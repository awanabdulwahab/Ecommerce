using EcommerceClassLibrary;
using EcommerceServices;
using EcommerceStore.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EcommerceStore.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)
         {
            var products = productsService.GetProducts();

            if (!search.IsNullOrWhiteSpace())
            {
                products = products.Where(p => p.Name != null && p.Name.Contains(search)).ToList();

            }           
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CatagoriesService catagoriesService = new CatagoriesService();
            var listofCatagory = catagoriesService.GetCatagories();
            return PartialView(listofCatagory);
        }
        // POST: Product
        [HttpPost]
        public ActionResult Create(NewCatagoryViewModel model)
        {
            var newproduct = new ProductModel();
            newproduct.Name = model.Name;
            newproduct.Description = model.Description;
            newproduct.Price = model.Price;

            CatagoriesService catagoriesService = new CatagoriesService();
            newproduct.Catagory = catagoriesService.GetCatagory(model.CatagoryId);
            productsService.SaveProduct(newproduct);
            return RedirectToAction("ProductTable");
        }  
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = productsService.GetProduct(id);
            return PartialView(product);
        }
        // POST: Product
        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        
        // POST: Product
        [HttpPost]
        public ActionResult Delete(int id)
        {
            productsService.DeleteProduct(id);
            return RedirectToAction("ProductTable");
        }
    }
}