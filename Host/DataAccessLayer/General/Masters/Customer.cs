using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    //public enum CustomerType
    //{
    //    Supplier,
    //    Customer,
    //}

    public enum StatusType
    {
        Active,
        InActive,
        Blocked,
        InvoiceBlocked
    }

    public enum AllowEmailStatus
    {
        Yes,
        No
    }

    public enum AllowTCSStatus
    {
        Yes,
        No
    }

    public enum AllowSMSStatus
    {
        Yes,
        No
    }



    public class Customer : BaseCompany
    {

        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }


        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Password { get; set; }

        [MaxLength(100)]         
        public string? Mobile { get; set; }

        [MaxLength(100)]
        public string? ContactPerson { get; set; }

        [MaxLength(100)]       
        public string? ContactNumber { get; set; }

        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }
        public int? TaxID { get; set; }

        public int? Type { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
        public int? DistrictId { get; set; }
        [ForeignKey(nameof(DistrictId))]
        public virtual District? District { get; set; }

        [MaxLength(100)]
        public string? Notes { get; set; }

        [MaxLength(100)]
        public string? NumberOfCreditDays { get; set; }

        [MaxLength(100)]
        public string? NumberOfBlockDays { get; set; }

        [MaxLength(100)]
        public string? Executive { get; set; }

        [MaxLength(100)]
        public string? PinCode { get; set; }

        [MaxLength(100)]
        public string? BankName { get; set; }

        [MaxLength(100)]
        public string? BankBranch { get; set; }

        [MaxLength(100)]
        public string? AccountNumber { get; set; }

        [MaxLength(100)]
        public string? IfscCode { get; set; }

        [MaxLength(50)]
        public string? UpiId { get; set; }

        [MaxLength(50)]
        public string? Iban { get; set; }

        [MaxLength(50)]
        public string? SwiftCode { get; set; }

        public StatusType? Status { get; set; }

        public AllowEmailStatus? AllowEmail { get; set; }
        public AllowTCSStatus? AllowTCS { get; set; }
        public AllowSMSStatus? AllowSMS { get; set; }

        [MaxLength(200)]
        public string? BlockReason { get; set; }

        [MaxLength(200)]
        public string? CreditLimit { get; set; }
        public bool UseCostCentre { get; set; }

        [MaxLength(200)]
        public string? GstRegistrationType { get; set; }

        [MaxLength(200)]
        public string? GstNo{get;set;}

        [MaxLength(200)]
        public string? PanNo {get; set; }

        [MaxLength(200)]
        public string? TypeofDuty { get; set; }

        [MaxLength(200)]
        public string? GSTApplicablility { get; set; }

        [MaxLength(200)]
        public string? TaxType { get; set; }
        [MaxLength(200)]
        public string? HsnCode { get; set; }
        [MaxLength(200)]
        public string? TaxRate { get; set; }
        public bool MaintainBill { get; set; }
        public bool IsTaxApplicable { get; set; }





    }
}
