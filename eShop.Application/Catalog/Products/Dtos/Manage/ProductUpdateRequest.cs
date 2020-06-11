﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }

        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }
    }
}
