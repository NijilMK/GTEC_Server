using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{



    public class Quotation : BaseCompany
    {
        [Required]
        [MaxLength(100)]
      
        public int? QuotationIncrement { get; set; }
        public string? QuotationInvoice { get; set; }

        public string? Remarks { get; set; }


        [Required]
        public DateTime QuotationDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [Required]
        public decimal Total { get; set; }


        public decimal? Cess { get; set; }

        public decimal? AdditionalCess { get; set; }

        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }
        public decimal? Tax { get; set; }


  

        public bool? IsSynced { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Roundoff { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public virtual Employee? Employee { get; set; }

    
        public string? Narration { get; set; }


        public int? BillType { get; set; }

        public PaperSize? PaperSize { get; set; }

        public decimal? BillMargin { get; set; }

        public bool? Published { get; set; }

        public int? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customer { get; set; }


        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }


        public SalesStatus? SalesStatus { get; set; }

        public int? PrintType { get; set; }

       


        public string? CustomerName { get; set; }


        public string? CustomerGst { get; set; }

        public int? CustomerState { get; set; }
        [ForeignKey(nameof(CustomerState))]
        public virtual State? State { get; set; }
      

        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public DateTime? SyncedTime { get; set; }



    }
}
