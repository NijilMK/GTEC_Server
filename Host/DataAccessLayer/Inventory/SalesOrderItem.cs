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
    public class SalesOrderItem : BaseCompany
    {
        [Required]
        public int SalesOrderId { get; set; }
        [ForeignKey(nameof(SalesOrderId))]
        public virtual SalesOrder? SalesOrder { get; set; }

        [MaxLength(100)]
        public string? Emei { get; set; }

        public int? PurchasePartNumberId { get; set; }
        [ForeignKey(nameof(PurchasePartNumberId))]
        public virtual PurchaseItemsPartNumber? PurchaseItemsPartNumber { get; set; }

        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public virtual Item? Item { get; set; }


        public decimal ItemLandingCost { get; set; }


        public string? Batch { get; set; }

        public int? SizeId { get; set; }
        [ForeignKey(nameof(SizeId))]
        public virtual Size? Size { get; set; }

        public int? SkuId { get; set; }
        [ForeignKey(nameof(SkuId))]
        public virtual Sku? Sku { get; set; }


        public int? BaseUnitId { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        public decimal PackageQuantity { get; set; }

        public decimal CartelWeight { get; set; }


        public decimal CartelNumber { get; set; }


        public decimal BaseQuantity { get; set; }


        public decimal UnitQuantity { get; set; }


        public decimal BaseFreeQuantity { get; set; }

        public decimal BaseDamageQuantity { get; set; }

        public decimal ActualQuantity { get; set; }

        public decimal DamageQuantity { get; set; }

        public decimal FreeQuantity { get; set; }

        public decimal ItemFreeQuantity { get; set; }

        public decimal ItemFreeQuantityFor { get; set; }

        public decimal EstimateQuantity { get; set; }


        public decimal Cess { get; set; }

        public int ItemCessId { get; set; }

        [MaxLength(150)]
        public string? ItemCessName { get; set; }

        public decimal ItemCessPercentage { get; set; }

        public decimal ItemRawCess { get; set; }


        public decimal CessAmount { get; set; }


        public decimal MaximumRetailPrice { get; set; }


        public decimal SalesMaximumRetailPrice { get; set; }

        [Required]
        public decimal ItemRate { get; set; }

        public decimal ItemMargin { get; set; }

        public decimal MarginPurchaserate { get; set; }

        public decimal ItemCommission { get; set; }

        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }


        public int Analytics { get; set; }

        public int TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }

        public decimal Tax { get; set; }

        public bool IsTaxIncluded { get; set; }


        public decimal Discount { get; set; }


        public decimal Total { get; set; }

        public bool Published { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal AddDiscountPercentage { get; set; }

        public decimal AddDiscountAmount { get; set; }

        [MaxLength(200)]
        public string? ItemDescription { get; set; }

        public decimal DeliveredQuantity { get; set; }


    }
}
