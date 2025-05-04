using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class PurchaseRequestItem : BaseCompany
    {
        [Required]
        public int RequestId { get; set; }
        [ForeignKey(nameof(RequestId))]
        public virtual PurchaseRequest? PurchaseRequest { get; set; }
        [Required]
        public int? ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public virtual Item? Item { get; set; }

        public string? Batch { get; set; }
        public int? SkuId { get; set; }
        [ForeignKey(nameof(SkuId))]
        public virtual Sku? Sku { get; set; }
        public int BaseUnitId { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        public decimal BaseQuantity { get; set; }
        public decimal Rate { get; set; }
       
        
        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }
        public int? ItemCessId { get; set; }
        [MaxLength(100)]
        public string? ItemCessName { get; set; }
        public decimal? ItemCessPercentage { get; set; }
        public decimal ItemRawCess { get; set; }
        public decimal? Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public bool? Published { get; set; }
  
        public decimal? DiscountAmount { get; set; }
        public bool? IsTaxIncluded { get; set; }

    }
}
