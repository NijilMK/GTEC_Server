using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Accounting.Masters
{
    public class LedgerGroup : BaseCompany
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public virtual LedgerGroup? Parent  { get; set; }

        public Boolean? IsParent { get; set; }


    }
}
