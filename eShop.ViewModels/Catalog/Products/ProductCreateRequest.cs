using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace eShop.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        [Required(ErrorMessage = "Required To Enter The Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }

        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}
