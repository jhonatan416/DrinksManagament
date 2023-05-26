using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksManagament.Data
{
    public class ProductsByPallet : BaseEntity
    {
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("PalletId")]
        public Pallet Pallet { get; set; }
        public int PalletId { get; set; }

        public int Quantity { get; set; }

    }
}
