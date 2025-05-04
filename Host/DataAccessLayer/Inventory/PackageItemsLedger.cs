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
    public class PackageItemsLedger : BaseCompany
    {
        [Required]
        [StringLength(50)]
        public string? VoucherNumber { get; set; }

        [Required]
        public int ItemId { get; set; }
        [MaxLength(50)]
        public string? Batch { get; set; }
        [Required]
        public string? TransactionType { get; set; }
        [Required]
        public int? TransactionId { get; set; }

        [Required]
        public DateTime? TransactionDate { get; set; }

        [Required]
        public int? WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }

        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
