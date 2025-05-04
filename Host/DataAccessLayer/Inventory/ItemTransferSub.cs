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
    public class ItemTransferSub : BaseCompany
    {
        [Required]
       public int ItemId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Batch { get; set; }

        [Required]
        [MaxLength(100)]
        public string? StockTrans { get; set; }
       public int? Quantity { get; set; }
       public decimal? ItemRate { get; set; }
        public int? UnitId { get; set; }

        public int? BaseUnit { get; set; }

        public int? ToId { get; set; }
        public bool? Published { get; set; }

       public int? TransferId { get; set; }

        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }



    }
}
