using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DataAccessLayer.General.Masters
{
    public class Employee : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Email { get; set;}
         
        [MaxLength(100)]
        public string? Mobile { get; set; }

        
        [Required]
        public int DesignationId { get; set; }
        [ForeignKey(nameof(DesignationId))]
        public virtual Designation? Designation { get; set; } 
        
        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }

        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }         
        public int? DistrictId { get; set; }
        [ForeignKey(nameof(DistrictId))]
        public virtual District? District { get; set; }

        [MaxLength(100)]        
        public string? Notes { get; set; }

        [MaxLength(100)]
        public string? PinCode { get; set; }

        [MaxLength(100)]
        public string? ProfilePicture { get; set; }

        [MaxLength(100)]
        public string? VisaType { get; set; }

        [MaxLength(100)]
        public string? IqamaNumber { get; set; }         
        public DateTime? IqamaStartDate { get; set; }        
        public DateTime? IqamaEndDate { get; set; }

        [MaxLength(100)]
        public string? PassportNumber { get; set; }
        
        public DateTime? PassportStartDate { get;set; }         
        public DateTime? PassportEndDate { get; set; }

        [MaxLength(100)]
        public string? InsuranceNumber { get; set; }
         
        public DateTime? InsuranceStartDate { get; set; }
         
        public DateTime? InsuranceEndDate { get; set; }

        [MaxLength(100)]
        public string? LicenseNumber { get; set; }        
        public DateTime? LicenseStartDate { get; set; }         
        public DateTime? LicenseEndDate { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }       
        public bool? IsUser { get; set; }

    }
}
