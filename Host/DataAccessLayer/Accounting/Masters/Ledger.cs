using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.General.Masters;

namespace DataAccessLayer.Accounting.Masters
{
    public class Ledger :BaseCompany
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? MainAccountId { get; set; }
        [ForeignKey(nameof(MainAccountId))]
        public virtual LedgerGroup? MainAccount { get; set; }

        public int? SubAccountId { get; set; }
        [ForeignKey(nameof(SubAccountId))]
        public virtual LedgerGroup? SubAccount { get; set; }

        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public virtual LedgerGroup? ParentType { get; set; }

        public string? SACCode { get; set; }
        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Tax { get; set; }

        public int? CessId { get; set; }
        [ForeignKey(nameof(CessId))]
        public virtual Cess? Cess { get; set; }

        [MaxLength(50)]
        public string? TypeCode { get; set; }

        public int? TypeId { get; set; }

        public string? BalanceType {  get; set; }

        public decimal? OpeningBalance { get; set; }


    }
}
 