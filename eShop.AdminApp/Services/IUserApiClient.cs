using eShop.ViewModels.Common;
using eShop.ViewModels.System;
using eShop.ViewModels.System.Users;
using System.Threading.Tasks;

namespace eShop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserViewModel>> GetUsersPagings(GetUserPagingRequest request);
    }
}