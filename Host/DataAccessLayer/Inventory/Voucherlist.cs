 
namespace DataAccessLayer.Accounting.Transactions
{
    public class Voucherlist
    {
        public Voucher? Voucher { get; set; }
        public List<VoucherTransaction>? VoucherTransaction { get; set; }
        
    }
}
