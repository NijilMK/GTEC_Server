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
    public enum SaleType
    {
        Estimate,
        Sales,
        SalesReturn,
        DeliveryNote
    }
    public enum PaperSizes
    {
        Full,
        Half
    }
    public enum Status
    {
        Pending,
        Completed,
        InCompleted,
       
    }
    public enum SalesStatusType
    {
        Created,
        PartiallyDelivered,
        DeliveryCompleted
    }
    public enum CashTypes
    {
        Cash,
        Credit,
        Bank,
        CashCredit,
        BankCredit
    }

    public class SalesOrder : BaseCompany
    {
   


       
        [MaxLength(100)]
        public string? Invoice { get; set; } 
        public int? InvoiceIncrement { get; set; }

        [MaxLength(100)]
        public string? Remarks { get; set; }

    
        [MaxLength(100)]
        public string? DeviceId { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

   
        public DateTime? DueDate { get; set; }
         
        public DateTime? DeliveryDate { get; set; }

 
        public DateTime? CreditLastDate { get; set; }

        [Required]
        public decimal Total { get; set; }

    
        public decimal? DollarValue { get; set; }

        [MaxLength(100)]
        public string? PackingDetails { get; set; }

        public decimal? ReceiptAmount { get; set; }

        public decimal? Cess { get; set; }

        public decimal? AdditionalCess { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? BankAmount { get; set; }

        public int? BankId { get; set; }

        [ForeignKey(nameof(BankId))]
        public virtual Bank? Bank { get; set; }

    
        [MaxLength(100)]
        public string? BankPaymentMethod { get; set; }

  
        [MaxLength(100)]
        public string? GpayNumber { get; set; }
 
        [MaxLength(100)]
        public string? CardNumber { get; set; }

  
        [MaxLength(100)]
        public string? BankReference { get; set; }

        public decimal? Tax { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }

        public decimal? DeliveryAmount { get; set; }

        public decimal? PaymentAmount { get; set; } 

        public bool? IsMobile { get; set; }

        public bool? IsAssigned { get; set; }

        public bool? IsSynced { get; set; }

        public decimal? Other { get; set; }

        public decimal? Freight { get; set; }

        public decimal? Advance { get; set; }

        public decimal? Discount { get; set; }

        public decimal? RedeemedAmount { get; set; }

        public decimal? RedeemedPoints { get; set; }

        public decimal? GlobalMaximumRetailPrice { get; set; }

        public decimal? Roundoff { get; set; }

        public decimal? ReferenceAmount { get; set; }

        public int? SalesReference { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public virtual Employee? Employee { get; set; }

        public int? SalesmanId { get; set; }
        [ForeignKey(nameof(SalesmanId))]
        public virtual Employee? Salesman { get; set; }


 
        [MaxLength(100)]
        public string? Narration { get; set; }

        public SalesType? Type { get; set; }

        public int? BillTypeId { get; set; }
        [ForeignKey("BillTypeId")]
        public virtual BillType? BillType { get; set; }

        public PaperSizes? PaperSize { get; set; }

        public decimal? BillMargin { get; set; }

        public bool? Published { get; set; }

        public int? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customer { get; set; }


        public int? CustomerAddresId { get; set; }
        [ForeignKey(nameof(CustomerAddresId))]
        public virtual CustomerAddress? CustomerAddress { get; set; }

        public int? ShippingAddresId { get; set; }
        [ForeignKey(nameof(ShippingAddresId))]
        public virtual CustomerAddress? ShippingAddress { get; set; }

        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }


        [MaxLength(100)]
        public string? Longitude { get; set; }
 
        [MaxLength(100)]
        public string? Latitude { get; set; }

        public int? EstimateId { get; set; }

        public Status? Status { get; set; }

        public SalesStatusType? SalesStatus { get; set; }

        public CashTypes? CashType { get; set; }

        public bool? CashStatus { get; set; }

        public int? PrintType { get; set; }

        public int? AreaId { get; set; }
        [ForeignKey(nameof(AreaId))]
        public virtual Area? Area { get; set; }

        public int? RouteId { get; set; }
        [ForeignKey(nameof(RouteId))]
        public virtual Routes? Route { get; set; }

        public int? VehicleId { get; set; }
        [ForeignKey(nameof(VehicleId))]
        public virtual Vehicle? Vehicle { get; set; }



        public int? PackedBy { get; set; }

  
        [MaxLength(100)]
        public string? CustomerName { get; set; }
  
        [MaxLength(100)]
        public string? CustomerGst { get; set; }

        public int? CustomerState { get; set; }
        [ForeignKey(nameof(CustomerState))]
        public virtual State? State { get; set; }


        public decimal? CollectedAmount { get; set; }

        public decimal? AdjustmentAmount { get; set; }

        [MaxLength(100)]
        public string? AdjustmentReference { get; set; }
 
        [MaxLength(100)]
        public string? EwaybillNumber { get; set; }
 
        [MaxLength(100)]
        public string? ReferenceNumber { get; set; }

 
        [MaxLength(100)]
        public string? Buyer { get; set; }

 
        [MaxLength(100)]
        public string? PreCarriage { get; set; }
 
        [MaxLength(100)]
        public string? PlaceOfReceipt { get; set; }

 
        [MaxLength(100)]
        public string? FlightNumber { get; set; }
 
        [MaxLength(100)]
        public string? PortOfLanding { get; set; }
 
        [MaxLength(100)]
        public string? PortOfDischarge { get; set; }

 
        [MaxLength(100)]
        public string? FinalDestination { get; set; }
 
        [MaxLength(100)]
        public string? CountryFinalDestination { get; set; }

 
        [MaxLength(100)]
        public string? CountryOriginOfGoods { get; set; }
 
        [MaxLength(100)]
        public string? TransportMode { get; set; }
 
        [MaxLength(100)]
        public string? Place { get; set; }
 
        [MaxLength(100)]
        public string? VehicleNumber { get; set; }
 
        [MaxLength(100)]
        public string? ContactName { get; set; }
 
        [MaxLength(100)]
        public string? ContactAddress { get; set; }
         
        [MaxLength(100)]
        public string? ContactNumber { get; set; }

 
        [MaxLength(100)]
        public string? ContactGst { get; set; }

 
        [MaxLength(100)]
        public string? ContactState { get; set; }

 
        [MaxLength(100)]
        public string? EWayBillDetails { get; set; }

 
        [MaxLength(100)]
        public string? TermsAndConditions { get; set; }

     
        [MaxLength(100)]
        public string? DispatchDetails { get; set; }
 
        [MaxLength(100)]
        public string? CustomerDetails { get; set; }
 
        [MaxLength(100)]
        public string? CustomerEmail { get; set; }
      
        [MaxLength(100)]
        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }

        [MaxLength(100)]
        public string? SaleType { get; set; }

        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public DateTime? SyncedTime { get; set; }
    }
}
