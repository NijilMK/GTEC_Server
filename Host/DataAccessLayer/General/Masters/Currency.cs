using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Currency : Base
    {
        [Required]
        [MaxLength(100)]
        public string? CurrencyName { get; set; }
        public string? CurrencyCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CurrencySymbol { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CurrencyValue {  get; set; } 
    }
}
