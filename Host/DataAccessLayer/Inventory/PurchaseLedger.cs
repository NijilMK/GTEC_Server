using DataAccessLayer.Accounting.Masters;
using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class PurchaseLedger : BaseCompany
    {
        [Required]
        public int PurchaseId { get; set; }
        [ForeignKey(nameof(PurchaseId))]
        public virtual Purchase? Purchase { get; set; }
        public bool? IsTaxIncluded { get; set; }
        [Required]
        public int? LedgerId { get; set; }
        [ForeignKey(nameof(LedgerId))]
        public virtual Ledger ? Ledger { get; set; }
        public string? SacCode { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }

        [Required]
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public bool? Published { get; set; }


    }
}
