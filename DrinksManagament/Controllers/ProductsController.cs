using AutoMapper;
using DrinksManagament.Constants;
using DrinksManagament.Contracts;
using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrinksManagament.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;
        private readonly IPalletRepository palletRepository;
        private readonly IProductsByPalletRepository productsByPalletRepository;
        private readonly IProductTypeRepository productTypeRepository;

        public ProductsController(IMapper mapper,
            IProductRepository productRepository,
            IPalletRepository palletRepository,
            IProductsByPalletRepository productsByPalletRepository,
            IProductTypeRepository productTypeRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
            this.palletRepository = palletRepository;
            this.productsByPalletRepository = productsByPalletRepository;
            this.productTypeRepository = productTypeRepository;
        }
        public async Task<IActionResult> Index()
        {
            List<ProductVM> productVMs = mapper.Map<List<ProductVM>>(await productRepository.GetAllProductsWithDependecysAsync());

            return productVMs != null ?
                      View(productVMs) :
                      Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
        }

        public async Task<IActionResult> Create()
        {
            List<ProductTypeVM> productTypeVMs = mapper.Map<List<ProductTypeVM>>(await productTypeRepository.GetAllAsync());
            List<SelectListItem> productTypeListItem = productTypeVMs.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Name,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });

            ViewBag.ProductTypeListItem = productTypeListItem;

            List<PalletVM> palletVMs = mapper.Map<List<PalletVM>>(await palletRepository.GetAllAsync());
            List<SelectListItem> palletListItem = palletVMs.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Id.ToString(),
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });

            ViewBag.PalletListItem = palletListItem;

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Create(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                //Validar si la estiba tiene suficiente espacio para almacenar el producto
                Pallet pallet = await palletRepository.GetByIdAsync(productVM.Pallet.Id) ?? new Pallet();
                List<ProductsByPalletVM> productsByPallets = await productsByPalletRepository.GetAllProductsByPalletsId(productVM.Pallet.Id);
                int quantityOfProductsbypallet = productsByPallets.Sum(a => a.Quantity) + productVM.ProductsByPallet.Quantity;
                if (pallet.PositionCount < quantityOfProductsbypallet)
                {
                    return View(productVM);
                }

                Product product = mapper.Map<Product>(productVM);
                product.DateCreated = DateTime.Now;
                product.DateModified = DateTime.Now;
                product.ProductType = null;
                await productRepository.AddAsync(product);

                ProductsByPallet productsByPallet = new ProductsByPallet()
                {
                    ProductId = product.Id,
                    PalletId = productVM.Pallet.Id,
                    Quantity = productVM.ProductsByPallet.Quantity,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                };
                await productsByPalletRepository.AddAsync(productsByPallet);

                return RedirectToAction(nameof(Index));
            }
            return View(productVM);
        }
    }
}
