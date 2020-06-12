using Microsoft.AspNetCore.Http;

namespace eShop.ViewModels.Catalog.Products.Manage
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

        public IFormFile ThumbnailImage { get; set; }
    }
}
