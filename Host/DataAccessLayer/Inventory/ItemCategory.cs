using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class ItemCategory : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; } 

        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public virtual ItemCategory? ParentCategory { get; set; } 
        [MaxLength(100)]
        public string? Image { get; set; }
         
    }
}
