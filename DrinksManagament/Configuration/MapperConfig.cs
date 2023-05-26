using AutoMapper;
using DrinksManagament.Data;
using DrinksManagament.Models;

namespace DrinksManagament.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<ProductType, ProductTypeVM>().ReverseMap();
            CreateMap<Pallet, PalletVM>().ReverseMap();
            CreateMap<ProductsByPallet, ProductsByPalletVM>().ReverseMap();
        }
    }
}
