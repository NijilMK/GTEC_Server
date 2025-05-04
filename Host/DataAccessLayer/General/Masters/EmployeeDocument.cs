using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class EmployeeDocument :BaseCompany
    {
        
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }

        [Required]
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }

        [MaxLength(100)]
        [Required]
        public string? UploadedFilePath { get; set; }
        
        public int? CountryId { get;set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
             
        [Required]
        public bool Status { get; set; }        

    }
}
