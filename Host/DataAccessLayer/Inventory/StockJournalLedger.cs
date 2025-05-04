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
    public class StockJournalLedger : BaseCompany
    {
        [Required]
        public int StockJournalId { get; set; }
        public int? LedgerId { get; set; }   

        public decimal? Amount { get; set; }

        public bool? Published { get; set; }        
 
    }
}
