using DrinksManagament.Contracts;
using DrinksManagament.Data;

namespace DrinksManagament.Repositories
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
