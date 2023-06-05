using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Contracts.Business
{
    public interface IProductsByPalletBusiness
    {
        Task<List<ProductsByPalletVM>> GetAllProductsByPalletsId(int palletId);
        Task<bool> ValidateQuantityForPalletsById(int palletId, int quantityNewProduct);
        Task<ProductsByPalletVM> AddAsync(ProductVM productVM);

    }
}
