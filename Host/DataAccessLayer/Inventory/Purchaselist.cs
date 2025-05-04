using DataAccessLayer.Inventory;

namespace DataAccessLayer.Inventory
{
    public class Purchaselist
    {
        public Purchase? Purchase { get; set; }
        public List<PurchaseItems>? PurchaseItems { get; set; }
        public List<PurchaseLedger>? PurchaseLedger { get; set; }
    }
}
