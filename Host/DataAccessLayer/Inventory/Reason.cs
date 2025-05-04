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
    public enum ReasonStatus
    {
        A,
        I,
        D
    }
    public class Reason : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? ReasonText { get; set; } 

        [Required]
        [MaxLength(100)]
        public string? ReasonCategory { get; set; }

        [Required]
        public ReasonStatus ReasonStatus { get; set; }


    }
}
