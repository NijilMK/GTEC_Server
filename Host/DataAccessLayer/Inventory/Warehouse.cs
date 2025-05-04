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
    public class Warehouse : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        
        [MaxLength(100)]
        public string? Address { get; set; }

          
        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }

        
        [MaxLength(100)]
        public string? PinCode { get; set; }

        
        [MaxLength(100)]
        public string? ContactPerson { get; set; }

       
        [MaxLength(100)]
        public string? ContactNumber { get; set; }
           
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }         
              

    }
}
