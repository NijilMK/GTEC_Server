using DataAccessLayer.General.Masters;
using DataAccessLayer.Accounting.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class LedgerTransaction : BaseCompany
    {
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public string? TransactionType { get; set; }

        [Required]
        public int TransactionId { get; set; }

        [Required]
        public string? VoucherNumber { get; set;}

        [Required]
        public int LedgerId { get; set; }
        [ForeignKey(nameof(LedgerId))]
        public virtual Ledger? Ledgers { get; set; }

        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }

        [Required]
        public int ToLedgerId { get; set; }
        [ForeignKey(nameof(ToLedgerId))]
        public virtual Ledger? Ledgerss{ get; set; }
        
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branches { get; set; }

        [MaxLength(1000)]
        public string? Narration { get; set; }




    }

    public interface IItemLedgerRepository
    {
        // Define other methods if needed

        List<ItemLedger> GetByTransaction(string transactionType, int transactionId);
    }
}
