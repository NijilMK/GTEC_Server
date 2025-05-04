using DataAccessLayer.Accounting.Masters;
using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{

    public enum Transactions
    {
        Sales,
        Purchase,
        Receipt,
        Payment,
        SalesReturn,
        PurchaseReturn,
        SalesOrder,
        PurchaseOrder,
        Journal,
        Package,
        Quotation,
        Contra,
        PurchaseRequest,
    }
    public class BillType : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(5)]
        public string? Seperator { get; set; }

        [MaxLength(100)]
        public string? Prefix { get; set; }

        [MaxLength(100)]
        public string? Suffix { get; set; }

        [Required]
        public int StartNo { get; set; }

        public Transactions Transaction { get; set; }

        public int? PrintTypeId { get; set; }
        [ForeignKey(nameof(PrintTypeId))]
        public virtual PrintType? PrintType { get; set; }
        public int? CashLedgerId { get; set; }
        [ForeignKey(nameof(CashLedgerId))]
        public virtual Ledger? CashLedger { get; set; }
        public int? BankLedgerId { get; set; }
        [ForeignKey(nameof(BankLedgerId))]
        public virtual Ledger? BankLedger { get; set; }
        public int? TaxLedgerId {  get; set; }
        [ForeignKey(nameof(TaxLedgerId))]
        public virtual Ledger? TaxLedger { get; set; }

    }
}
