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
    public class AccountAgeing : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? VoucherNumber { get; set; }

        public int TableReferenceId { get; set; }

        [MaxLength(100)]
        public string? TableReferenceName { get; set; }

        public DateTime TableCreatedDate { get; set; }


        public DateTime TableCalculatedDate { get; set; }


        public int LedgerId { get; set; }

        public decimal CreditAmount { get; set; }

        public decimal DebitAmount { get; set; }

        public decimal PaidAmount { get; set; }


        public decimal BalanceAmount { get; set; }

        public int Status { get; set; }

        public decimal LastPaidAmount { get; set; }

        public string? PaymentType { get; set; }

        public int PaymentId { get; set; }
        
        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }

    }
}
