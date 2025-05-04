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
    


    public class PackageLog : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public int? UserTypeID { get; set; }
        [ForeignKey(nameof(UserTypeID))]
        public virtual UserType? UserType { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual User? User { get; set; }

        [Required]
        public int PackageID { get; set; }
        [ForeignKey(nameof(PackageID))]
        public virtual Package? Package { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Comments { get; set; }

        public int? EmployeeID { get; set; }
        [ForeignKey(nameof(EmployeeID))]
        public virtual Employee? Employee { get; set; }
        public int? ReasonID { get; set; }

        public DateTime? LogDate { get; set; }

        [Required]
        public int PackageStatusID { get; set; }
        [ForeignKey(nameof(PackageStatusID))]
        public virtual PackageStatus? PackageStatus { get; set; }


    }
}
