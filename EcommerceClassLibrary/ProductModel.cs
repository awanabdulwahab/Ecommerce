using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceClassLibrary
{
    public class ProductModel: BaseModel
    {
        public CatagoryModel Catagory { get; set; }
        
        public decimal Price { get; set; }
    }
}
