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
    public class Bank : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? BankName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Ifsc { get; set; }

        [Required]
        [MaxLength(100)]
        public string? AccountNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Branch { get; set; }
        
        [MaxLength(100)]
        public string? Address { get; set; }
        
        [MaxLength(100)]
        public string? PhoneNumber { get;set; } 
    }
}
