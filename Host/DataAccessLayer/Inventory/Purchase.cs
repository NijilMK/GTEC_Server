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
    public enum TransactionType
    {
        Credit,
        Cash,
        Bank
    }
    public enum PurchaseStatus
    {
        Completed,
        InCompleted,
        Pending
    }
    public enum PurchasesStatus
    {
        Draft,
        Send,
        Confirmed
    }
    public enum PurchaseType
    {
        Purchase,
        PurchaseReturn,
        PurchaseOrder,
        Order
    }

    public class Purchase : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Invoice { get; set; }
        public int? InvoiceIncrement { get; set; }

        [Required] 
        public DateTime InvoiceDate { get; set; }
        public DateTime PurchaseDate { get; set; } 
        public string? BillNumber { get; set; }
        public int BillTypeId { get; set; }
        [ForeignKey(nameof(BillTypeId))]
        public virtual BillType ? BillType { get; set; }
 
        public int? SupplierId { get;set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual Customer? Customer { get; set; }  
        public CashType CashType { get; set; }

        public int? PrintType { get; set; }     
        public DateTime DueDate { get; set; }    
        public DateTime ReceivedDate { get; set; }   
        public decimal Total { get; set; } 
        public decimal Tax { get; set; }
        public decimal AdditionalCess { get; set; } 
        public decimal Discount { get; set; }

        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }

        public decimal Roundoff { get; set; } 
        public string? Narration { get; set; } 
        public int? OrderId { get; set; }
        public PurchaseStatus? Status { get; set; }      
        public PurchaseType? Type { get; set; } 
        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency? Currency { get; set; }       
        public decimal CurrencyExecAmount { get; set; }
        public bool? Published { get; set; }
 
        [MaxLength(100)]
        public string? SupplierGst { get; set; }

        public int? SupplierStateId { get; set; }
        [ForeignKey(nameof(SupplierStateId))]
        public virtual State? SupplierState { get; set; }
 
        public string? EWayBillNumber { get; set; }       
        public string? SupplierReference { get; set; } 
        public string? PoReferenceNumber { get; set; } 
        public string? CustomerReferenceNumber { get;set; }     
        public string? Notes { get; set; }      
        public string? EWayBillDetails { get; set; }  
        public bool IsDraft { get; set; }
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
