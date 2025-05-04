using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Tax :BaseCompany
    {
        [Required] 
        public float Percent { get; set; }

        public float? CGST { get; set; }
        public float? SGST { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; } 

         

    }
}
