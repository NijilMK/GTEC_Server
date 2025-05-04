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

    public class PurchaseRequest : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? RequestNumber{ get; set; }
        public int? RequestIncrement { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public DateTime RequestDate { get; set; }
        public string? RequestReferenceNumber { get; set; }
        public int BillTypeId { get; set; }
        [ForeignKey(nameof(BillTypeId))]
        public virtual BillType? BillType { get; set; }

        public int? SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual Customer? Customer { get; set; }

        public int? PrintType { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }

        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }
        public decimal AdditionalCess { get; set; }
        public decimal Discount { get; set; }
        public decimal Roundoff { get; set; }
        public string? Narration { get; set; }
        public PurchaseStatus? Status { get; set; }
        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency? Currency { get; set; }
        public decimal CurrencyExecAmount { get; set; }
        public bool? Published { get; set; }

        public string? Notes { get; set; }
     
        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public bool IsSynced { get; set; }
        public DateTime? SyncedTime { get; set; }

        public int? WarehouseID { get; set; }
        [ForeignKey(nameof(WarehouseID))]
        public virtual Warehouse? Warehouse { get; set; }
    }
}
