using AutoMapper;
using DrinksManagament.Contracts.Business;
using DrinksManagament.Contracts.Repository;
using DrinksManagament.Data;
using DrinksManagament.Models;
using MessagePack.Formatters;

namespace DrinksManagament.Business
{
    public class ProductsByPalletBusiness : IProductsByPalletBusiness
    {
        private readonly IProductsByPalletRepository productsByPalletRepository;
        private readonly IPalletRepository palletRepository;
        private readonly IMapper mapper;

        public ProductsByPalletBusiness(
            IProductsByPalletRepository productsByPalletRepository,
            IPalletRepository palletRepository,
            IMapper mapper)
        {
            this.productsByPalletRepository = productsByPalletRepository;
            this.palletRepository = palletRepository;
            this.mapper = mapper;
        }

        public async Task<ProductsByPalletVM> AddAsync(ProductVM productVM)
        {
            ProductsByPallet productsByPallet = new ProductsByPallet()
            {
                ProductId = productVM.Id,
                PalletId = productVM.Pallet.Id,
                Quantity = productVM.ProductsByPallet.Quantity,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            await productsByPalletRepository.AddAsync(productsByPallet);
            return mapper.Map<ProductsByPalletVM>(productsByPallet);
        }

        public async Task<List<ProductsByPalletVM>> GetAllProductsByPalletsId(int palletId)
        {
            return await productsByPalletRepository.GetAllProductsByPalletsId(palletId);
        }

        public async Task<bool> ValidateQuantityForPalletsById(int palletId, int quantityNewProduct)
        {
            Pallet pallet = await palletRepository.GetByIdAsync(palletId) ?? new Pallet();
            List<ProductsByPalletVM> productsByPallets = await GetAllProductsByPalletsId(palletId);
            int quantityOfProductsbypallet = productsByPallets.Sum(a => a.Quantity) + quantityNewProduct;
            return pallet.PositionCount < quantityOfProductsbypallet;
        }


    }
}
