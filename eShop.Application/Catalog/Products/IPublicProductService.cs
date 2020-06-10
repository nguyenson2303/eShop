using eShop.Application.Catalog.Products.Dtos;
using eShop.Application.Catalog.Products.Dtos.Public;
using eShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCAtegoryId(GetProductPagingRequest request);
    }
}
