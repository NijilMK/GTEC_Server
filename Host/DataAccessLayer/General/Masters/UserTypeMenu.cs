using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class UserTypeMenu : BaseCompany
    {
        [Required]  
        public int UserTypeId { get; set; }
        [ForeignKey(nameof(UserTypeId))]
        public virtual UserType? UserType { get; set; }

        [Required]
        public int MenuId { get;set; }
        [ForeignKey(nameof(MenuId))]
        public virtual Menu? Menu { get; set; }

        public bool? IsEdit { get; set; }
        public bool? IsAdd { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsView { get; set; }
        public bool? IsPrint { get; set; }
        public bool? IsExport { get; set; }
        
     

    }
}
