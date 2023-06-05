using AutoMapper;
using DrinksManagament.Constants;
using DrinksManagament.Contracts;
using DrinksManagament.Contracts.Business;
using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrinksManagament.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductBusiness productBusiness;
        private readonly IProductTypeBusiness productTypeBusiness;
        private readonly IPalletBusiness palletBusiness;
        private readonly IProductsByPalletBusiness productsByPalletBusiness;

        public ProductsController(
            IProductBusiness productBusiness,
            IProductTypeBusiness productTypeBusiness,
            IPalletBusiness palletBusiness,
            IProductsByPalletBusiness productsByPalletBusiness)
        {
            this.productBusiness = productBusiness;
            this.productTypeBusiness = productTypeBusiness;
            this.palletBusiness = palletBusiness;
            this.productsByPalletBusiness = productsByPalletBusiness;
        }
        public async Task<IActionResult> Index()
        {
            List<ProductVM> productVMs = await productBusiness.GetAllProductsWithDependecysAsync();
            return productVMs != null ?
                      View(productVMs) :
                      Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
        }

        public async Task<IActionResult> Create()
        {
            List<SelectListItem> productTypeListItem = await productTypeBusiness.GetProductTypeListItem();
            ViewBag.ProductTypeListItem = productTypeListItem;

            List<SelectListItem> palletListItem = await palletBusiness.GetPalletListItem();
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
                if (await productsByPalletBusiness.ValidateQuantityForPalletsById(productVM.Pallet.Id, productVM.ProductsByPallet.Quantity))
                {
                    return View(productVM);
                }
                await productBusiness.AddAsync(productVM);

                await productsByPalletBusiness.AddAsync(productVM);

                return RedirectToAction(nameof(Index));
            }
            return View(productVM);
        }
    }
}
