﻿using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShop.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        public ProductApiClient(IHttpClientFactory httpClientFactory,
                  IHttpContextAccessor httpContextAccessor,
                   IConfiguration configuration)
           : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductViewModel>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&languageId={request.LanguageId}");

            return data;
        }
    }
}