using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Promotion
    {
        public int id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string ProductIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
    }
}
