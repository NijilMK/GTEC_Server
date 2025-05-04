using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class User : BaseCompany
    {
         
        //[Required]
        //public int UserTypeId{ get; set; }
        //[ForeignKey(nameof(UserTypeId))]
        //public virtual UserType? UserType { get; set; }
        
        //[Required]
        //public int DesignationId { get; set; }
        //[ForeignKey(nameof(DesignationId))]
        //public virtual Designation? Designation { get; set; }
        //public byte[]? Salt { get; set; }

        [MaxLength(100)]
        [Required]
        public string? UserName { get; set; }

        [MaxLength(100)]
        [Required]
        public string? Password { get; set; }

        [MaxLength(100)]         
        public string? Contact { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }      
        public int? EmployeeId { get; set; }

    }

    public class UserLogin : Base
    {
        [MaxLength(100)]
        [Required]
        public string? UserName { get; set; }

        [MaxLength(100)]
        [Required]
        public string? Password { get; set; }

        [MaxLength(100)]
        public string? Contact { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }
        public int? EmployeeId { get; set; }
    }
}
