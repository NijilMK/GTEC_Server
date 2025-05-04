using DataAccessLayer.Accounting.Masters;
using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
   public class Printer : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? PrinterName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? PrinterType { get;set; }
        public bool? IsDefault { get; set; }     
       
    }
}
