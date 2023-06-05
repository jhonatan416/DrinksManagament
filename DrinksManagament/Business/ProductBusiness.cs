using AutoMapper;
using DrinksManagament.Contracts.Business;
using DrinksManagament.Contracts.Repository;
using DrinksManagament.Data;
using DrinksManagament.Models;
using DrinksManagament.Repositories;

namespace DrinksManagament.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductBusiness(IGenericRepository<Product> genericRepository,
            IMapper mapper,
            IProductRepository productRepository
            ) 
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }

        public async Task<ProductVM> AddAsync(ProductVM productVM)
        {
            Product product = mapper.Map<Product>(productVM);
            product.DateCreated = DateTime.Now;
            product.DateModified = DateTime.Now;
            product.ProductType = null;
            await productRepository.AddAsync(product);
            productVM.Id = product.Id;
            return productVM;
        }

        public async Task<List<ProductVM>> GetAllProductsWithDependecysAsync()
        {
            return mapper.Map<List<ProductVM>>(await productRepository.GetAllProductsWithDependecysAsync());
        }

    }
}
