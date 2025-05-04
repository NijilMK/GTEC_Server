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
    public class StockJournalItems : BaseCompany
    {
        [Required]
        public int StockJournalId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Type { get; set; }

        public int? WarehouseId { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? SalesRate { get; set; }

        public decimal? PurchaseRate { get; set; }

        public decimal? StockValue { get; set; }

        public bool? Published { get; set; }

         
    }
}
