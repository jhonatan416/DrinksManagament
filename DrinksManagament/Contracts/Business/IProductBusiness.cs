using DrinksManagament.Business;
using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Contracts.Business
{
    public interface IProductBusiness
    {
        Task<List<ProductVM>> GetAllProductsWithDependecysAsync();
        Task <ProductVM> AddAsync(ProductVM productVM);

    }
}
