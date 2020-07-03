using EcommerceClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceStore.ViewModels
{
    public class HomeViewModel
    {
        public List<CatagoryModel> FeatureCatagories { get; set; }
        public List<ProductModel> FeatureProducts { get; set; }
    }
}