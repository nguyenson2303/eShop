using Microsoft.AspNetCore.Http;
using System;

namespace eShop.Application.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int id { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }
    }
}