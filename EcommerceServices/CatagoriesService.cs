using EcommerceClassLibrary;
using EcommerceDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceServices
{
    public class CatagoriesService
    {
        public void SaveCatagory(CatagoryModel catagory)
        {
            using(var context = new EcommerceStoreContext())
            {
                context.Catagories.Add(catagory);
                context.SaveChanges();
            }
        }
        public void UpdateeCatagory(CatagoryModel catagory)
        {
            using(var context = new EcommerceStoreContext())
            {
                context.Entry(catagory).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        } 
        public void DeleteCatagory(int id)
        {
            using(var context = new EcommerceStoreContext())
            {
                //context.Entry(catagory).State = System.Data.Entity.EntityState.Deleted;
                var catagory = context.Catagories.Find(id);
                context.Catagories.Remove(catagory);
                context.SaveChanges();
            }
        }

        public List<CatagoryModel> GetCatagories()
        {
            using(var context = new EcommerceStoreContext())
            {
                return context.Catagories.ToList();
            }
        }

        public List<CatagoryModel> GetFeatureCatagories()
        {
            using (var context = new EcommerceStoreContext())
            {
                
                return context.Catagories.Where(x => x.isFeatured && x.ImageURL != null).ToList();
            }
        }
        public CatagoryModel GetCatagory(int id)
        {
            using(var context = new EcommerceStoreContext())
            {
                
                return context.Catagories.Find(id);
            }
        }
    }
}
