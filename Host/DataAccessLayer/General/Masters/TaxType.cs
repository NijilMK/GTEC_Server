using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class TaxType :Base
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }      

    }
}
