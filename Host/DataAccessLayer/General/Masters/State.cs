using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class State : Base
    {
        
        [MaxLength(100)]
        [Required]
        public string? StateName { get; set; }

        [MaxLength(50)]
        [Required]
        public string? StateCode { get; set; }
      
        [Required]
        public int CountryId{ get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
        
    }
}
