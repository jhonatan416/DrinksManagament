using System.ComponentModel.DataAnnotations;

namespace DrinksManagament.Models
{
    public class ProductTypeVM
    {
        public int Id { get; set; }
        
        [Display(Name = "Nombre")]
        public string? Name { get; set; }
    }
}
