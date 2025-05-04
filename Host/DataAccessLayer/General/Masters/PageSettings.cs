using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class PageSettings : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Key { get; set; }

        public string? Value { get; set; }

        public int? LastUpdatedBy { get; set; }

        public int? CreatedBy { get; set; }

    }
}
