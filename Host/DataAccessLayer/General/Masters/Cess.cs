using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Cess : BaseCompany
    {
        [Required]
        public decimal Percent { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; } 

    }
}
