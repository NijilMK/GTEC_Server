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
    public class Driver : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? DriverName { get; set; }
 
        [MaxLength(100)]
        public string? LicenseNumber { get; set; }
 
        [MaxLength(100)]
        public string? Address { get; set; }

        
        [MaxLength(100)]
        public string? MobileNumber { get; set; }        

    }
}
