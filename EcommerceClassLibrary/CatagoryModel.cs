using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceClassLibrary
{
    public class CatagoryModel: BaseModel
    {
        public string ImageURL { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
