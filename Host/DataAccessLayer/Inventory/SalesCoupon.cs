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
    public class SalesCoupon : BaseCompany
    {
        [Required]
        public int SalesId { get; set; }

        [Required]
        public int CouponId { get; set; }
        [ForeignKey(nameof(CouponId))]
        public virtual Coupon? Coupon { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public bool? Published { get; set; }  

    }
}
