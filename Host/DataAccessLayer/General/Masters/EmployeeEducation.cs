using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class EmployeeEducation : BaseCompany
    {
        
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }

        [MaxLength(50)]
        [Required]
        public string? Course { get; set; }

        [MaxLength(100)]
        [Required]
        public string? StartYear { get; set; }

        [MaxLength(100)]
        [Required]
        public string? EndYear { get; set; }

        [MaxLength(50)]
        [Required]
        public string? Type { get; set;}

        [MaxLength(50)]
        [Required]
        public decimal AggregateMarkPercentage { get; set; } 

    }
}
