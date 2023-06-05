using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrinksManagament.Contracts.Business
{
    public interface IPalletBusiness
    {
        Task<List<SelectListItem>> GetPalletListItem();

    }
}
