﻿using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}