using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Area : BaseCompany
    {
        [Required]        
        [MaxLength(100)]       
        public string? Name { get; set; }     
        
        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }        
         
        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }        
         
        public int? DistrictId { get; set; }
        [ForeignKey(nameof(DistrictId))]
        public virtual District? District { get; set; }
 
    }
}
