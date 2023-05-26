using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksManagament.Data
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal PriceForOne { get; set; }
        public decimal PriceForStock { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
    }
}
