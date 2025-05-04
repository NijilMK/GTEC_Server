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
    public enum VoucherType
    {
        Payment,
        Receipt,
        Journal,
        Contra
    }

    public class Voucher : BaseCompany
    {       
        public VoucherType? VoucherTypes { get; set; }
        public DateTime? VoucherDate { get; set; }

        [MaxLength(100)]
        public string? Narration { get; set; }
        public decimal? Amount { get; set; }
        public int? BillType { get; set; }
        [ForeignKey(nameof(BillType))]
        public virtual BillType? BillTypes { get; set; }

        [MaxLength(100)]
        public string? VoucherNumber { get; set; }
        public bool IsSynced { get; set; }
        public DateTime? SyncedTime { get; set; }
        public int? InvoiceIncrement { get; set; }

        public string?LedgerType { get; set; }

        public int? LedgerID { get; set; }
        [ForeignKey(nameof(LedgerID))]
        public virtual Ledger? Ledger { get; set; }

        public int? CostCentreID { get; set; }
        [ForeignKey(nameof(CostCentreID))]
        public virtual CostCentre? CostCentre { get; set; }


    }
}


