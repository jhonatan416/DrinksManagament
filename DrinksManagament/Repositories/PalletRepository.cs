using DrinksManagament.Contracts.Repository;
using DrinksManagament.Data;

namespace DrinksManagament.Repositories
{
    public class PalletRepository : GenericRepository<Pallet>, IPalletRepository
    {
        public PalletRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
