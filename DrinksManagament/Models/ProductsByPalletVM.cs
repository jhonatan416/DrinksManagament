using DrinksManagament.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksManagament.Models
{
    public class ProductsByPalletVM
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PalletId { get; set; }
        
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
    }
}
