using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;
using System.Threading.Tasks;

namespace eShop.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id, string languageId);
    }
}