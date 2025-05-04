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
    public class PurchaseItemsPartNumber : BaseCompany
    {
        [Required]
        public int PurchaseId { get; set; }
        [ForeignKey(nameof(PurchaseId))]
        public virtual Purchase? Purchase { get; set; }

        [Required]
        public int PurchaseItemsId { get; set; }
        [ForeignKey(nameof(PurchaseItemsId))]
        public virtual PurchaseItems? PurchaseItems { get; set; }


        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public virtual Item? Item { get; set; }

        [Required]
        [MaxLength(100)]
        public string? PartNumber { get; set; }

        public bool? Status { get; set; }
        public bool? Published { get; set; }
          

    }
}
