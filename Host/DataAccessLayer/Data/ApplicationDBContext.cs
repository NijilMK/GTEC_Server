using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Procedure;
using DataAccessLayer.Inventory;

namespace DataAccessLayer
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        
        //public DbSet<DataAccessLayer.Accounting.Masters.LedgerGroup> LedgerGroups { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Masters.Ledger> Ledgers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Masters.AccountSettings> AccountSettings { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Transactions.Aeging> Aegings { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Transactions.AegingTransaction> AegingTransactions { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Transactions.Voucher> Vouchers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Accounting.Transactions.VoucherTransaction> VoucherTransactions { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Cess> Cess { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Area> Areas { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Branch> Branches { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Brand> Brands { get; set; } = default!;

        //public DbSet<DataAccessLayer.General.Masters.Country> Countries { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Customer> Customers { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.CustomerAddress> CustomerAddresses { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Designation> Designations { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.District> Districts { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Employee> Employees { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.EmployeeDocument> EmployeeDocuments { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.EmployeeEducation> EmployeeEducations { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Menu> Menus { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Routes> Routes { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Sku> Sku { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.State> States { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Tax> Taxes { get; set; } = default!;
        public DbSet<DataAccessLayer.General.Masters.User> Users { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.UserType> UserTypes { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Bank> Banks { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Coupon> Coupons { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Currency> Currency { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Size> Size { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Vehicle> Vehicles { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.UserTypeMenu> UserTypeMenus { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Company> Companies { get; set; } = default!;  
        //public DbSet<DataAccessLayer.General.Masters.Address> Addresses { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.BillType> BillTypes { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.PrintType> PrintTypes { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.BillFormat> BillFormats { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.CompanySettings> CompanySettings { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Driver> Drivers { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Printer> Printers { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.TaxType> TaxTypes { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Language> Languages { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Manufacturer> Manufacturers { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.PageSettings> PageSettings { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.FinancialYear>FinancialYears { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.CostCentre> CostCentres { get; set; } = default!;
        //public DbSet<DataAccessLayer.General.Masters.Transporter> Transporters { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.HsnCode> HsnCodes { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.ItemGroup> ItemGroups { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.ItemCategory> ItemCategories { get; set; } = default!; 
        //public DbSet<DataAccessLayer.Inventory.Warehouse> Warehouses { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.Item> Items { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.ItemLog> ItemLogs { get; set; } = default!;       
        //public DbSet<DataAccessLayer.Inventory.ItemImage> ItemImages { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.ItemWarehouse> ItemWarehouses { get; set; } = default!;

        //public DbSet<DataAccessLayer.Inventory.PurchaseOrder> PurchaseOrders { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseOrderItems> PurchaseOrderItems { get; set; } = default!;

        //public DbSet<DataAccessLayer.Inventory.Purchase> Purchases { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseItems> PurchaseItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseItemsPartNumber> PurchaseItemsPartNumbers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseLedger> PurchaseLedgers { get; set; } = default!;

        //public DbSet<DataAccessLayer.Inventory.PurchaseReturn> PurchaseReturns { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseReturnItems> PurchaseReturnItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseReturnLedger> PurchaseReturnLedgers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.Quotation> Quotations { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.QuotationItems> QuotationItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseRequest> PurchaseRequests { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PurchaseRequestItem> PurchaseRequestItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.Sales> Sales { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesCoupon> SalesCoupons { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesItems> SalesItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesLedger> SalesLedgers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesPrint> SalesPrints{ get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesOrder> SalesOrders { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesOrderItem> SalesOrderItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.Package> Packages { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PackageStatus> PackageStatuses { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PackageItem> PackageItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesReturn> SalesReturns { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesReturnItems> SalesReturnItems { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.SalesReturnLedger> SalesReturnLedgers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.ItemLedger> ItemLedgers { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.LedgerTransaction> LedgerTransactions { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.Reason> Reasons { get; set; } = default!; 
        //public DbSet<DataAccessLayer.Inventory.PackageLog> PackageLogs { get; set; } = default!;
        //public DbSet<DataAccessLayer.Inventory.PackageItemsLedger> PackageItemsLedgers{ get; set; } = default!;

        //public DbSet<DataAccessLayer.General.Masters.UserStatusSettings> UserStatusSettingses { get; set; } = default!;


        ////for stored procedure  
        //public DbSet<ResponseProcedure> ResponseProcedure { get; set; } = default!;

        //public DbSet<ReportResponseProcedure> ReportResponseProcedure { get; set; } = default!;

        //public DbSet<TrailBalanceResponseProcedure> TrailBalanceResponseProcedure { get; set; } = default!;
        //public DbSet<FinantialReportResponseProcedure> FinantialReportResponseProcedure { get; set; } = default!;
        //public DbSet<JsonResponseProcedure> JsonResponseProcedure { get; set; } = default!;

        //public DbSet<LedgerDueResponseProcedure> LedgerDueResponseProcedure { get; set; } = default!;

        //public IEnumerable<JsonResponseProcedure> SP_JsonResponseProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");
        //    if (escapedspName == "SP_GetLedgerHierarchy")
        //    {
        //        return this.JsonResponseProcedure.FromSqlInterpolated($"call SP_GetLedgerHierarchy({json})").ToArray();

        //    }
        //    else if (escapedspName == "SP_GetLedgerHierarchy")
        //    {
        //        var jsonResult = this.JsonResponseProcedure
        //       .FromSqlRaw($"CALL SP_GetLedgerHierarchy({json})")
        //       .AsEnumerable()
        //       .Select(r => new JsonResponseProcedure
        //       {
        //           JSONString = r.JSONString,
        //           ID =r.ID
        //       });
        //        var j = 1;
        //        return jsonResult;

        //    }
        //    else
        //    {
        //        var jsonResult = this.JsonResponseProcedure
        //       .FromSqlRaw($"CALL {escapedspName}({json})")
        //       .AsEnumerable()
        //       .Select(r => new JsonResponseProcedure
        //       {
        //           JSONString = r.JSONString,
        //           ID = r.ID
        //       });
        //        var t = 1;
        //        return jsonResult;

        //    }


        //}

        //public IEnumerable<FinantialReportResponseProcedure> SP_ResponseFInantialProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");

        //    if (escapedspName == "SP_ProfitandLoss")
        //    {
        //        return this.FinantialReportResponseProcedure.FromSqlInterpolated($"call SP_ProfitandLoss({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_StockLedgerReport")
        //    {
        //        return this.FinantialReportResponseProcedure.FromSqlInterpolated($"call SP_StockLedgerReport({json})").ToArray();
        //    }
        //    else
        //    {
        //        return this.FinantialReportResponseProcedure.FromSqlInterpolated($"call {escapedspName}({json})").ToArray();

        //    }
        //}
        //public IEnumerable<TrailBalanceResponseProcedure> SP_ResponseTrailProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");

        //    if (escapedspName == "SP_TrailBalance")
        //    {
        //        return this.TrailBalanceResponseProcedure.FromSqlInterpolated($"call SP_TrailBalance({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_StockLedgerReport")
        //    {
        //        return this.TrailBalanceResponseProcedure.FromSqlInterpolated($"call SP_StockLedgerReport({json})").ToArray();
        //    }
        //    else
        //    {
        //        return this.TrailBalanceResponseProcedure.FromSqlInterpolated($"call {escapedspName}({json})").ToArray();

        //    }
        //}

        //public IEnumerable<LedgerDueResponseProcedure> SP_LedgerDueReportProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");
        //    return this.LedgerDueResponseProcedure.FromSqlInterpolated($"call SP_CustomerDue({json})").ToArray();

        //}
        //public IEnumerable<ReportResponseProcedure> SP_ResponseReportProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");

        //    if (escapedspName == "SP_LedgerReport")
        //    {
        //        return this.ReportResponseProcedure.FromSqlInterpolated($"call SP_LedgerReport({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_StockLedgerReport")
        //    {
        //        return this.ReportResponseProcedure.FromSqlInterpolated($"call SP_StockLedgerReport({json})").ToArray();
        //    }
        //    else
        //    {
        //        return this.ReportResponseProcedure.FromSqlInterpolated($"call {escapedspName}({json})").ToArray();

        //    }
        //}

        //public IEnumerable<ResponseProcedure> SP_DeleteCustomerAddress(int id)
        //{
        //    return this.ResponseProcedure.FromSqlInterpolated($"call SP_DeleteCustomerAddress({id})").ToArray();

        //}

        //public IEnumerable<ResponseProcedure> SP_ResponseProcedure(string spName, string json)
        //{
        //    string escapedspName = spName.Replace("'", "''");
        //    if (escapedspName == "CreateOrUpdateItemWarehouseBatch")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call CreateOrUpdateItemWarehouseBatch({json})").ToArray();
        //    }else if (escapedspName == "SP_UpdatePackageLedger")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_UpdatePackageLedger({json})").ToArray();
        //    }else if (escapedspName  == "SP_UpdatePackageCompleted")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_UpdatePackageCompleted({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_LedgerReport")
        //    {
        //        var result = this.ResponseProcedure.FromSqlInterpolated($"call SP_LedgerReport({json})").ToArray();
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_LedgerReport({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_TrialBalance")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_TrailBalanceReport({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_ProfitLossReport")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_ProfitLossReport({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_BalanceSheetReport")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_BalanceSheetReport({json})").ToArray();
        //    }
        //    else if (escapedspName == "SP_StockLedgerReport")
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call SP_StockLedgerReport({json})").ToArray();
        //    }
        //    else
        //    {
        //        return this.ResponseProcedure.FromSqlInterpolated($"call {escapedspName}({json})").ToArray();

        //    }

        //}


        //public IEnumerable<ResponseProcedure> SP_RestoreProcedure(string spName, string p1, int p2)
        //{
        //    return this.ResponseProcedure.FromSqlInterpolated($"call UpdateItemWarehouseCurrentStock('{p1}',{p2})").ToArray();

        //}

        //public IEnumerable<ResponseProcedure> SP_GetPageDetails(string type, int id)
        //{
        //    return this.ResponseProcedure.FromSqlInterpolated($"call SP_GetSalesOrderDetails('{type}',{id})").ToArray();

        //}

        //public IEnumerable<ResponseProcedure> SP_RestoreAeging(int p2)
        //{
        //    return this.ResponseProcedure.FromSqlInterpolated($"call SP_RestoreVoucherAeging({p2})").ToArray();

        //}

        //public IEnumerable<ResponseProcedure> SP_RestoreSalesOrder(int p2)
        //{
        //    var result = this.ResponseProcedure.FromSqlInterpolated($"call SP_RestoreSalesOrder({p2})").ToArray();
        //    return this.ResponseProcedure.FromSqlInterpolated($"call SP_RestoreSalesOrder({p2})").ToArray();
            

        //}

        //public IEnumerable<ResponseProcedure> RestorePackage(int p2)
        //{
        //    return this.ResponseProcedure.FromSqlInterpolated($"call SP_RestorePackage({p2})").ToArray();

        //}

    }
}
