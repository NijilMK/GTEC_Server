using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Coupon : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? CouponCode { get; set; }
        
        [MaxLength(100)]
        public string? CouponImage { get; set; }

        [Required]
        public DateOnly DateFrom { get; set; }

        [Required]
        public DateOnly DateTo { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public decimal? Discount { get; set; }
        public bool? Published { get; set; }

        [MaxLength(100)]
        public string? NameLanguage { get; set; }

        
    }
}
