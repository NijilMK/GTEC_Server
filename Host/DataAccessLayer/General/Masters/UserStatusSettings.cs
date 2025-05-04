using DataAccessLayer.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class UserStatusSettings : BaseCompany
    {
        [Required]
        public int UserTypeId { get; set; }
        [ForeignKey(nameof(UserTypeId))]
        public virtual UserType? UserType { get; set; }

        [Required]
        public int PackageStatusId { get; set; }
        [ForeignKey(nameof(PackageStatusId))]
        public virtual PackageStatus? PackageStatus { get; set; }

        public bool? IsView { get; set; }

        public bool? IsEdit { get; set; }


        public bool? IsUpdate { get; set; }
    }
}
