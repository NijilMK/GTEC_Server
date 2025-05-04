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
    public class StockJournal : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? VoucherNumber { get;set; }

        [Required]
        public int BillType { get;set; }

        [Required]
        public DateTime Date { get;set; }
         
        [MaxLength(100)]
        public string? Remarks { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Reference { get; set; }

        public bool? Published { get; set; }  

    }
}
