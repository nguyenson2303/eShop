using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Cart
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
