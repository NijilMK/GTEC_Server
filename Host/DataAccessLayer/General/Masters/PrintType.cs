using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class PrintType : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        public int? PageSize { get; set; }

        [Required]
        public int? HalfPageSize { get; set; }

        [Required]
        [MaxLength(100)]
        public string? PdfFormat { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Code { get; set; }

        public string? PrintSettings { get; set; }

    }
}
