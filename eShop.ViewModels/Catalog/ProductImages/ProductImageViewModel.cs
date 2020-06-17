using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Catalog.ProductImages
{
    public class ProductImageViewModel
    {
        public int id { get; set; }
        public string FilePath { get; set; }
        public bool IsDefault { get; set; }
        public long FileSize { get; set; }
    }
}
