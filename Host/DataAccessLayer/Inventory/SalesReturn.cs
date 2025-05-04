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


    public class SalesReturn : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Invoice { get; set; }
        public int? InvoiceIncrement { get; set; }

        public string? Remarks { get; set; }

        public string? DeviceId { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public DateTime CreditLastDate { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public decimal DollarValue { get; set; }
        public DateTime? SalesRefDate { get; set; }
        public string? SalesRefNo { get; set; } 
        public string? PackingDetails { get; set; }

        public decimal? ReceiptAmount { get; set; }

        public decimal? Cess { get; set; }

        public decimal? AdditionalCess { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? BankAmount { get; set; }

        public int? BankId { get; set; }

        [ForeignKey(nameof(BankId))]
        public virtual Bank? Bank { get; set; }


        public string? BankPaymentMethod { get; set; }


        public string? GpayNumber { get; set; }


        public string? CardNumber { get; set; }


        public string? BankReference { get; set; }

        public decimal? Tax { get; set; }

        public decimal? DeliveryAmount { get; set; }

        public decimal? PaymentAmount { get; set; }

        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }

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



        public string? Narration { get; set; }

        public SalesType? Type { get; set; }

        public int? BillType { get; set; }

        public PaperSize? PaperSize { get; set; }

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


        public string? Longitude { get; set; }

        public string? Latitude { get; set; }

        public int? EstimateId { get; set; }

        public SaleStatus? Status { get; set; }

        public SalesStatus? SalesStatus { get; set; }

        public CashType? CashType { get; set; }

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


        public string? CustomerName { get; set; }


        public string? CustomerGst { get; set; }

        public int? CustomerState { get; set; }
        [ForeignKey(nameof(CustomerState))]
        public virtual State? State { get; set; }
        public decimal? CollectedAmount { get; set; }

        public decimal? AdjustmentAmount { get; set; }


        public string? AdjustmentReference { get; set; }


        public string? EwaybillNumber { get; set; }


        public string? ReferenceNumber { get; set; }


        public string? Buyer { get; set; }


        public string? PreCarriage { get; set; }


        public string? PlaceOfReceipt { get; set; }


        public string? FlightNumber { get; set; }


        public string? PortOfLanding { get; set; }


        public string? PortOfDischarge { get; set; }


        public string? FinalDestination { get; set; }


        public string? CountryFinalDestination { get; set; }


        public string? CountryOriginOfGoods { get; set; }


        public string? TransportMode { get; set; }


        public string? Place { get; set; }


        public string? VehicleNumber { get; set; }


        public string? ContactName { get; set; }


        public string? ContactAddress { get; set; }


        public string? ContactNumber { get; set; }


        public string? ContactGst { get; set; }


        public string? ContactState { get; set; }


        public string? EWayBillDetails { get; set; }


        public string? TermsAndConditions { get; set; }

        public string? DispatchDetails { get; set; }


        public string? CustomerDetails { get; set; }


        public string? CustomerEmail { get; set; }


        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }


        public string? SaleType { get; set; }

        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }
        public DateTime? SyncedTime { get; set; }

    }
}
