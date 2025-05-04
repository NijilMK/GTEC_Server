using DataAccessLayer.Inventory;

namespace DataAccessLayer.Inventory
{
    public class SalesReturnlist
    {
        public SalesReturn? SalesReturn { get; set; }
        public List<SalesReturnItems>? SaleReturnItems { get; set; }
        public List<SalesReturnLedger>? SalesReturnLedger { get; set; }
    }
}
