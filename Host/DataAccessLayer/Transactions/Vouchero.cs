using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Transactions
{
    public class Vouchero : BaseCompany
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int SalesReferenceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Narration { get; set; }


        public string? Longitude { get; set; }

        public string? Lattitude { get; set; }

        public int IsAutocheck { get; set; }

        public DateTime TransactionDate { get; set; }

        public string? VoucherType { get; set; }

        public string? ContraType { get; set; }

        public int BillType { get; set; }

        public int LedgerId { get; set; }

        public decimal OpeningBalance { get; set; }

        public decimal OpeningPaid{ get; set; }

        public string? Reference { get; set; }

        public int Salesman { get; set; }

        public int ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set;}

        public bool IsPost { get; set; }

        public bool Published { get; set;}

        [MaxLength(100)]
        public string? VoucherNumber { get; set; }

        [MaxLength(100)]
        public string? DeviceId { get; set; }

        [MaxLength(100)]
        public string? Invoices { get; set; }

        [MaxLength(100)]
        public string? VoucherInvoice { get; set; }

        public int CostCenter { get; set; }

        public int? InvoiceIncrement { get; set; }

    }
}
