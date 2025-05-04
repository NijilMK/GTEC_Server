using DataAccessLayer.Accounting.Masters;
using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class SalesLedger : BaseCompany
    {
        [Required]
        public int SalesId { get; set; }
        [ForeignKey(nameof(SalesId))]
        public virtual Sales? Sales { get; set; }

        public bool? IsTaxIncluded { get; set; }

        public int? LedgerId { get; set; }
        [ForeignKey(nameof(LedgerId))]
        public virtual Ledger? Ledger { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }

        [Required]
        public decimal Tax { get; set; }
        public bool? Published { get; set; }
         
    }
}
