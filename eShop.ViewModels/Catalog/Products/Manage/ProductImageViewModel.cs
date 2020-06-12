using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Catalog.Products.Manage
{
    public class ProductImageViewModel
    {
        public int id { get; set; }
        public string FilePath { get; set; }
        public bool IsDefault { get; set; }
        public long FileSize { get; set; }
    }
}
