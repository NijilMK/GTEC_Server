using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.General.Masters;
using DataAccessLayer.Accounting.Masters;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Inventory;

namespace DataAccessLayer.Accounting.Transactions
{
    public enum Status
    {
        Created,
        Pending,
        Completed
    }

    public class Aeging : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? VoucherNumber { get; set; }
        public DateTime? TransactionDate { get; set; }

        [MaxLength(100)]
        public string? TransactionType { get; set; }
        public int? TransactionId { get; set; }
        public int? LedgerId { get; set; }
        [ForeignKey(nameof(LedgerId))]
        public virtual Ledger? Ledgers { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public decimal? LastPaidAmount { get; set; }
        public Status? Status { get; set; }

        public bool? IsAdvance { get; set; }

        public string? AdvanceVoucherType { get; set; }
        public int? AdvanceVoucherId { get; set; }
        [ForeignKey(nameof(AdvanceVoucherId))]
        public virtual Voucher? Voucher { get; set; }

        public string? AdvanceVoucherNumber { get; set; }

        public DateTime? AdvanceVoucherDate { get;  set; }
         
    }
}
 

