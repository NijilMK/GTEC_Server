using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Sku : BaseCompany
    {
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }

        [MaxLength(5)]
        [Required]
        public string? Code { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public Sku? Parent { get; set; }
        public int? BaseCount { get; set; }

    }
}
