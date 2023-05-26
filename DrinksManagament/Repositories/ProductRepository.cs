using AutoMapper;
using DrinksManagament.Contracts;
using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace DrinksManagament.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductRepository(ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        /// <summary>
        /// Retorna la totalidad de los productos con la información asociada a la estiba y la cantidad de producto
        /// </summary>
        /// <returns>Lista con la totalidad de los productos List<ProductVM></returns>
        public async Task<List<ProductVM>> GetAllProductsWithDependecysAsync()
        {
            List<Product> products = await context.Products
                .Include(Queryable => Queryable.ProductType)
                .ToListAsync();

            List<ProductVM> productVMs = mapper.Map<List<ProductVM>>(products);
            foreach (ProductVM productVM in productVMs)
            {
                productVM.ProductsByPallet = mapper.Map<ProductsByPalletVM>(context.ProductsByPallets.Where(f => f.ProductId == productVM.Id).FirstOrDefault());
            }

            return productVMs;
        }

        //public async Task<Product> AddOnlyProduct(Product product)
        //{
        //    await context.AddAsync(product);
        //    await context.SaveChangesAsync();
        //    return entity;
        //}
    }
}
