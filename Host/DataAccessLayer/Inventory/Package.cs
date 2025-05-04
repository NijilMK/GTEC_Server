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
    public enum IsExport
    {
       Yes,
       No
    }    

    public class Package : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? PackageCode { get; set; }

        public int? InvoiceIncrement { get; set; }


        [Required]
        public int BillTypeID { get;set; }
        [ForeignKey(nameof(BillTypeID))]
        public virtual BillType? BillType { get; set; }

        [Required]
        [MaxLength(100)]
        public string? BillTypeNumber { get; set; }

        public int SalesOrderID { get; set; }

        [ForeignKey(nameof(SalesOrderID))]
        public virtual SalesOrder? SalesOrder { get; set; }

        [Required]
        public int WarehouseID { get; set; }
        [ForeignKey(nameof(WarehouseID))]
        public virtual Warehouse? Warehouse { get; set; }

        [Required]
        public int PackageStatusID { get; set; }
        [ForeignKey(nameof(PackageStatusID))]
        public virtual PackageStatus? PackageStatus { get; set; }

        [Required]
        public int UserId { get;set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User{ get; set; }

        [Required]
        public int CreatedBy { get; set; }
        [ForeignKey(nameof(CreatedBy))]
        public virtual UserType? UserType { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public IsExport IsExport{get;set;}

        [Required]
        public bool IsInvoiceBlocked { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customers { get; set; }

        public int? CustomerAddresId { get; set; }
        [ForeignKey(nameof(CustomerAddresId))]
        public virtual CustomerAddress? CustomerAddress { get; set; }

        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }
        public int? ShippingAddresId { get; set; }
        [ForeignKey(nameof(ShippingAddresId))]
        public virtual CustomerAddress? ShippingAddress { get; set; }
        public DateTime? SyncedTime { get; set; }


    }
}
