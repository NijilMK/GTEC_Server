using DataAccessLayer.Inventory;

namespace DataAccessLayer.Inventory
{
    public class PurchaseReturnlist
    {
        public PurchaseReturn? PurchaseReturn { get; set; }
        public List<PurchaseReturnItems>? PurchaseReturnItems { get; set; }
        public List<PurchaseReturnLedger>? PurchaseReturnLedger { get; set; }
    }
}
