using AutoMapper;
using DrinksManagament.Contracts;
using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DrinksManagament.Repositories
{
    public class ProductsByPalletRepository : GenericRepository<ProductsByPallet>, IProductsByPalletRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductsByPalletRepository(ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ProductsByPalletVM>> GetAllProductsByPalletsId(int palletId)
        {
            return mapper.Map<List<ProductsByPalletVM>>(await context.ProductsByPallets.Where(w => w.PalletId == palletId).ToListAsync());
        }
    }
}
