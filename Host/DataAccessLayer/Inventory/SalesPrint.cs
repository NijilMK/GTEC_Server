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
    public class SalesPrint : BaseCompany
    {
        [Required]
        public int PrinterId { get; set; }
        [ForeignKey(nameof(PrinterId))] 
        public virtual Printer? Printer { get; set; }

        [Required]
        public int SalesId { get; set; }
        [ForeignKey(nameof (SalesId))]
        public virtual Sales? Sales { get; set; }

        public int? BillFormatId { get; set; }
        [ForeignKey(nameof(BillFormatId))]
        public virtual BillFormat? BillFormat { get; set; }
        public int? BillType { get; set; }

        public bool? IsPrint { get; set; }

        public bool? Published { get; set; } 
    }
}
