using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Contracts.Repository
{
    public interface IProductsByPalletRepository : IGenericRepository<ProductsByPallet>
    {
        Task<List<ProductsByPalletVM>> GetAllProductsByPalletsId(int palletId);

    }
}
