using DataAccessLayer.General.Masters; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace DataAccessLayer.Transactions;
 
    public enum VoucherType
    {
        Voucher,
        Cheque        
    }
    public class AccountAegingTrans : BaseCompany
    {
        [Required]
        public int AegingId { get; set; }

        public int VoucherId { get; set; }
        [ForeignKey(nameof(VoucherId))]
        public virtual Vouchero? Voucher { get; set; }

        public decimal PaidAmount { get; set; }

        [Required]
        [MaxLength(100)]
        public VoucherType VouchersType { get; set; }

        public bool Published { get; set; }

        public int BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }


    }
 
  
    
 
 