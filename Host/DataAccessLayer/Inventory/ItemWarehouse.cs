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
    public class ItemWarehouse : BaseCompany
    {     
        public int? ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public virtual Item? Item { get; set; }   
        
        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }
      
        [MaxLength(100)]
        public string? Batch { get; set;}          
        public decimal? OpeningStock { get; set; } 
        
        public decimal? OpeningStockRate { get; set; }
        
        public DateTime? ManufacturingDate { get; set; } 
        
        public DateTime? ExpiryDate { get; set; } 
        
        public decimal? SalesRate { get; set; }
        public decimal? NewSalesRate { get; set; }
        public DateTime? NewSalesRateApplicableDate { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? NewPurchaseRate { get; set; }
        public DateTime? NewPurchaseRateApplicableDate { get; set; }
        public decimal? LandingCost { get; set; }  
        
        public decimal? SpecialRate { get; set; } 
        
        public decimal? SpecialRate2 { get; set; } 
        
        public decimal? WholesaleRate { get; set; }  
        
        public decimal? CurrentStock { get; set; }

        public decimal? PendingPackageQuantity { get; set; }
        public decimal? ClosingStockRate { get; set; } 
        
        [MaxLength(100)]
        public string? Rack { get; set; } 
        
        [MaxLength(100)]
        public string? Row { get; set; }
        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
    }
}
