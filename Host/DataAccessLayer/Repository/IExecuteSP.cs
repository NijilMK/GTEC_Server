

using DataAccessLayer.Procedure;

namespace Repository
{
    public interface IExecuteSP
    {
        List<JsonResponseProcedure> GetJsonReports(string spName, string json);


        List<FinantialReportResponseProcedure> GetFinantialReports(string spName, string json);

        List<TrailBalanceResponseProcedure> GetTrailBalance(string spName, string json);

        List<ReportResponseProcedure> GetReportDetails(string spName, string json);

        List<LedgerDueResponseProcedure> GetLedgerDueReport(string spName, string json);

        List<ResponseProcedure> GetSample(string spName, string json);
        List<ResponseProcedure> UpdateItemWarehouseCurrentStock(string spName,string p1,int p2);

        List<ResponseProcedure> RestoreAeging(int p1);
        List<ResponseProcedure> RestorePackage(int p1); 
        List<ResponseProcedure> DeleteCustomerAddress(int p1);

        List<ResponseProcedure> RestoreSalesOrder(int p1);
        List<ResponseProcedure> GetPageDetails(string type,int Id);


    }
}
