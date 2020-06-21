using EcommerceClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDatabase
{
    public class EcommerceStoreContext : DbContext, IDisposable
    {
        public EcommerceStoreContext() : base("ecommerce")
        {

        }
        // Migration Concept in entity framework
        public DbSet<CatagoryModel> Catagories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
    }
}
