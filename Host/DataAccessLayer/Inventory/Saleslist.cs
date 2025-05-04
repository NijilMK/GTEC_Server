using DataAccessLayer.Inventory;

namespace DataAccessLayer.Inventory
{
    public class Saleslist
    {
        public Sales?  Sale { get; set; }
        public List<SalesItems>? SaleItems { get; set; }
        public List<SalesLedger>? SalesLedger { get; set; }
    }
}
