using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory;
public class Item : BaseCompany
{
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; } 

    [MaxLength(100)]
    public string? Barcode { get; set; } 
    public int? CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public virtual ItemCategory? Category { get; set; } 

    public int? SubCategoryId { get; set; }
    [ForeignKey(nameof(SubCategoryId))]
    public virtual ItemCategory? SubCategory { get; set; } 

    public int? BrandId { get; set; }
    [ForeignKey(nameof(BrandId))]
    public virtual Brand? Brand { get; set; } 

    public int? HsnCodeId { get; set; }
    [ForeignKey(nameof(HsnCodeId))]
    public virtual HsnCode? HsnCode { get; set; }    
    
    public int? TaxId { get; set; }
    [ForeignKey(nameof(TaxId))]
    public virtual Tax? Tax { get; set; } 

    public int? SkuId { get; set; }
    [ForeignKey(nameof(SkuId))]
    public virtual Sku? Sku { get; set; }  
    
    public decimal? SalesRate { get; set; }
    public DateTime? SalesRateApplicableDate { get; set; } 
     public decimal? PurchaseRate { get; set; }
    public DateTime? PurchaseRateApplicableDate { get; set; } 
    public decimal? LandingCost { get; set; } 
    public decimal? SpecialRate { get; set; } 
    public decimal? SpecialRate2 { get; set; }  
    public int? ManufacturerId { get; set; }
    [ForeignKey(nameof(ManufacturerId))]
    public virtual Manufacturer? Manufacturer { get; set; }

    public string? Image { get; set; }

    [MaxLength(100)]
    public string? Description { get; set; }    
    public string? Unit { get; set; }
    public string? Denomination { get; set; }
    public string? Convertion { get; set; }
    public bool MaintainBatch { get; set; }
    public bool UseManufacturingDate { get; set; }
    public bool UseExpiry { get; set; }
    public bool IsGstApplicable { get; set; }
    public string? Hsn { get; set; }
    public string? HsnDescription { get; set; }
    public int? GstRate { get; set; }
    public string? CessRate { get; set; }
    public string? TypeOfSupply { get; set; }
    public string? ReportingUQC { get; set; }
    public string? MRP { get; set; }
    public DateTime? MRPApplicableFrom { get; set; }
    public string? StandardCost { get; set; }
    public DateTime? StandardCostApplicableFrom { get; set; }
    public string? StandardSellRate { get; set; }
    public DateTime? StandardSellRateApplicableFrom { get; set; }  

}

public class ItemLog : BaseCompany
{
    [Required]
    public int ItemId { get; set; }
    [ForeignKey(nameof(ItemId))]
    public virtual Item? Item { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [MaxLength(100)]
    public string? Barcode { get; set; }

    public int? CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public virtual ItemCategory? Category { get; set; }

    public int? SubCategoryId { get; set; }
    [ForeignKey(nameof(SubCategoryId))]
    public virtual ItemCategory? SubCategory { get; set; }

    public int? BrandId { get; set; }
    [ForeignKey(nameof(BrandId))]
    public virtual ItemGroup? Brand { get; set; }

    public int? HsnCodeId { get; set; }
    [ForeignKey(nameof(HsnCodeId))]
    public virtual HsnCode? HsnCode { get; set; }

    [Required]
    public int TaxId { get; set; }
    [ForeignKey(nameof(TaxId))]
    public virtual Tax? Tax { get; set; }

    public int? SkuId { get; set; }
    [ForeignKey(nameof(SkuId))]
    public virtual Sku? Sku { get; set; }

    public decimal? SalesRate { get; set; }

    public DateTime? SalesRateApplicableDate { get; set; }

    public decimal? PurchaseRate { get; set; }

    public DateTime? PurchaseRateApplicableDate { get; set; }

    public decimal? LandingCost { get; set; }

    public decimal? SpecialRate { get; set; }

    public decimal? SpecialRate2 { get; set; }

    public int? ManufacturerId { get; set; }
    [ForeignKey(nameof(ManufacturerId))]
    public virtual Manufacturer? Manufacturer { get; set; }
    public string? Image { get; set; }

}
