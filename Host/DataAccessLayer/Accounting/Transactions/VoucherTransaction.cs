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
    public class VoucherTransaction : BaseCompany
    {
        public int VoucherId { get;set; }
        [ForeignKey(nameof(VoucherId))]
        public virtual Voucher? Voucher { get; set; }

        public int LedgerId { get; set; }
        [ForeignKey(nameof(LedgerId))]
        public virtual Ledger? Ledger { get; set; }

        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        [MaxLength(150)]
        public string? SubNarration { get; set; }

          

    }
}


