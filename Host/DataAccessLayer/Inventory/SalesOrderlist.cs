using DataAccessLayer.Inventory;

namespace DataAccessLayer.Inventory
{
    public class SalesOrderlist
    {
        public SalesOrder? SalesOrder { get; set; }
        public List<SalesOrderItem>? SalesOrderItem { get; set; }
         
    }
}
