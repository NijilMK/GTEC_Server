using DataAccessLayer.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Menu : BaseCompany
    {
        
        [MaxLength(100)]
        [Required]
        public string? MenuName { get; set; }

        [MaxLength(100)]
        [Required]
        public string? Url { get; set; }

        [MaxLength(100)]       
        public string? Icon { get; set;}

        [MaxLength(100)]       
        public int? Parent { get; set; }
        [ForeignKey(nameof(Parent))]
        public virtual Menu? Menus { get; set; }


        [MaxLength(50)]       
        public string? MenuOrder { get; set; }

        [MaxLength(50)]         
        public string? ShortKey { get; set; }

        [MaxLength(50)]      
        public string? Status { get; set; }

    }
}
