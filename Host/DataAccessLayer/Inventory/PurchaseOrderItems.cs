using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class PurchaseOrderItems : BaseCompany
    {
        [Required]
        public int PurchaseOrderId { get; set; }
        [ForeignKey(nameof(PurchaseOrderId))]
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public int ItemOrder { get; set; }
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
        public decimal? FreeQuantity { get; set; }
        public decimal? BaseFreeQuantity { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal BaseQuantity { get; set; }
        public decimal OrderQuantity { get; set; }
        public decimal Rate { get; set; }
        public decimal MaximumRetailPrice { get; set; }
        [MaxLength(100)]
        public string? ItemDescription { get; set; }
        [Required]
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
        public int? Analytics { get; set; }
        public decimal Total { get; set; }
        public bool? Published { get; set; }
        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsTaxIncluded { get; set; }

    }
}
