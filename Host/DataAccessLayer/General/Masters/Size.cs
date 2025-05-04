using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Size : BaseCompany

    {
        [Required]
        [MaxLength(100)]
        public string? Code { get;set; }

        [Required]
        [MaxLength(100)]
        public string? Sizes { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }       

    }
}
