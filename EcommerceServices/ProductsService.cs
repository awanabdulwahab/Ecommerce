using EcommerceClassLibrary;
using EcommerceDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceServices
{
    public class ProductsService
    {
        public void SaveProduct(ProductModel product)
        {
            using(var context = new EcommerceStoreContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(ProductModel product)
        {
            using(var context = new EcommerceStoreContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        } 
        public void DeleteProduct(int id)
        {
            using(var context = new EcommerceStoreContext())
            {
                //context.Entry(catagory).State = System.Data.Entity.EntityState.Deleted;
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public List<ProductModel> GetProducts()
        {
            using(var context = new EcommerceStoreContext())
            {
                return context.Products.ToList();
            }
        }
        public ProductModel GetProduct(int id)
        {
            using(var context = new EcommerceStoreContext())
            {
                
                return context.Products.Find(id);
            }
        }
    }
}
