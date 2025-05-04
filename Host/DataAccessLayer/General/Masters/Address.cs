using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Address : Base
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        
        [MaxLength(100)]
        public string? ContactPerson { get; set; }
        
        [MaxLength(20)]
        public string? ContactNumber { get; set; }
        
        [MaxLength(20)]
        public string? Address1 { get; set; }

      
        [MaxLength(20)]
        public string? Address2 { get; set; }
        [Required]
        [MaxLength(100)]
        public string? PinCode { get; set; }

        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }

        public int? DistrictId { get; set; }
        [ForeignKey(nameof(DistrictId))]
        public virtual District? District { get; set; }

        [MaxLength(50)]
        public string? MobileNo { get; set; }

        [MaxLength(50)]
        public string? MailId { get; set; }
        [MaxLength(50)]
        public string? GstRegistrationType { get; set; }
        [MaxLength(100)]
        public string? GstNumber { get; set; }
        [MaxLength(100)]
        public string? PanNumber { get; set; }
        

    }
}
