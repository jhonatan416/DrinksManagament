using DrinksManagament.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace DrinksManagament.Models
{
    public class ProductVM
    {
        public ProductVM()
        {
            ProductType = new ProductTypeVM();
            ProductsByPallet = new ProductsByPalletVM();
            Pallet = new PalletVM();
        }

        public int Id { get; set; }
        
        [Display(Name = "Nombre")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Precio unitario")]
        [Required]
        public decimal PriceForOne { get; set; }

        [Display(Name = "Precio al por mayor")]
        [Required]
        public decimal PriceForStock { get; set; }
        
        public ProductTypeVM ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductsByPalletVM ProductsByPallet { get; set;}
        public PalletVM Pallet { get; set; }
    }
}
