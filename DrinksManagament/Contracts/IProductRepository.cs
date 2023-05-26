using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<ProductVM>> GetAllProductsWithDependecysAsync();
    }
}
