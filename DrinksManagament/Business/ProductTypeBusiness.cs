using AutoMapper;
using DrinksManagament.Contracts.Business;
using DrinksManagament.Contracts.Repository;
using DrinksManagament.Data;
using DrinksManagament.Models;
using DrinksManagament.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DrinksManagament.Business
{
    public class ProductTypeBusiness : IProductTypeBusiness
    {
        private readonly IProductTypeRepository productTypeRepository;
        private readonly IMapper mapper;

        public ProductTypeBusiness(IProductTypeRepository productTypeRepository,
            IMapper mapper)
        {
            this.productTypeRepository = productTypeRepository;
            this.mapper = mapper;
        }

        public async Task<List<SelectListItem>> GetProductTypeListItem()
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
            return productTypeListItem;
        }

    }
}
