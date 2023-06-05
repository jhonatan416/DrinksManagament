using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Contracts.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<ProductVM>> GetAllProductsWithDependecysAsync();
    }
}
