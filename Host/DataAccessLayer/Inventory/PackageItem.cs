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
    public class PackageItem : BaseCompany
    {
        [Required]
        public int PackageId { get; set; }

        [ForeignKey(nameof(PackageId))]
        public virtual Package? Package { get; set; }

        [Required]
        public int ItemId { get; set; }

        public int? SalesOrderID { get; set; }

        [ForeignKey(nameof(SalesOrderID))]
        public virtual SalesOrder? SalesOrder { get; set; }

        public int? SalesOrderItemID { get; set; }

        [ForeignKey(nameof(SalesOrderItemID))]
        public virtual SalesOrderItem? SalesOrderItem { get; set; }


        [ForeignKey(nameof(ItemId))]
        public virtual Item? Item { get; set; }

        [Required]
        public float PackageQuantity { get; set; }

        public float SalesQuantity { get; set; }


        [Required]
        public float ItemAmount { get; set; }
        public float? ItemUsed{get;set;}
        public float? ItemBalance{get;set;}
        [Required]
        public int TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        public virtual Tax? Taxes { get; set; }

        [Required]
        public decimal Tax { get; set; }
        [Required]
        public bool IsTaxIncluded { get; set; }



    }
}
