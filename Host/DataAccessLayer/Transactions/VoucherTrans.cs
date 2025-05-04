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
    public class VoucherTrans : BaseCompany
    {
        [Required]
        public int VoucherId { get; set; }

        [Required]
        public int AccountLedgerId { get; set; }

        [Required]
        public decimal CreditAmount { get; set; }

        [MaxLength(200)]
        public string? SubNarration { get; set; }

        [Required]
        public decimal DebitAmount { get; set; }

        public bool Published { get; set; }
        
    }
}
