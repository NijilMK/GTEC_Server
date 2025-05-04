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
    public class AegingTransaction : BaseCompany
    {
        [Required]
        public int AegingId { get; set; }
        [ForeignKey(nameof(AegingId))]
        public virtual Aeging? Aeging { get; set; }
        [Required]
        public int VoucherId { get; set; }
        public decimal? Paid { get; set; }
        [MaxLength(100)]
        public string? VoucherType { get; set; }
        public DateTime? VoucherDate { get; set; }
 

    }
}


