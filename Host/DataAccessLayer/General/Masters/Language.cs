using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public enum LanguageDirection
    {
       RightToLeft,
        LeftToRight
    }
    public class Language : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get;set; }

        [Required]
        public LanguageDirection Direction { get; set; }

    }
     
}
