using AutoMapper;
using DrinksManagament.Contracts.Business;
using DrinksManagament.Contracts.Repository;
using DrinksManagament.Data;
using DrinksManagament.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrinksManagament.Business
{
    public class PalletBusiness : IPalletBusiness
    {
        private readonly IPalletRepository palletRepository;
        private readonly IMapper mapper;

        public PalletBusiness(IPalletRepository palletRepository,
            IMapper mapper)
        {
            this.palletRepository = palletRepository;
            this.mapper = mapper;
        }

        public async Task<List<SelectListItem>> GetPalletListItem()
        {
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
            return palletListItem;
        }
    }
}
