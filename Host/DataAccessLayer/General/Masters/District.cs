using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class District : Base
    {
         
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
        
        [Required]
        public int StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }
         
        [Required]
        public int CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }      

    }
}
