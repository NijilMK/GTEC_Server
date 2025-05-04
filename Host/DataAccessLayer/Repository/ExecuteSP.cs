
//using DataAccessLayer;
//using DataAccessLayer.Procedure;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System.Text.Json;

//namespace Repository
//{
//    public class ExecuteSP : IExecuteSP
//    {
//        private ApplicationDBContext _context = null;
//        public ExecuteSP(ApplicationDBContext _context)
//        {
//            this._context = _context; 
//        }


//        public List<JsonResponseProcedure> GetJsonReports(string spName, string json)
//        {
//            return _context.SP_JsonResponseProcedure(spName, json).ToList();
//        }
//        public List<FinantialReportResponseProcedure> GetFinantialReports(string spName, string json)
//        {
//            return _context.SP_ResponseFInantialProcedure(spName, json).ToList();
//        }


//        public List<TrailBalanceResponseProcedure> GetTrailBalance(string spName, string json)
//        {
//            return _context.SP_ResponseTrailProcedure(spName, json).ToList();
//        }

//        public List<ReportResponseProcedure> GetReportDetails(string spName, string json)
//        {
//            return _context.SP_ResponseReportProcedure(spName,json).ToList();
//        }

//        public List<LedgerDueResponseProcedure> GetLedgerDueReport(string spName, string json)
//        {
//            return _context.SP_LedgerDueReportProcedure(spName, json).ToList();
//        }

//        public List<ResponseProcedure> DeleteCustomerAddress(int p1)
//        {
//            return _context.SP_DeleteCustomerAddress(p1).ToList();
//        }
//        public List<ResponseProcedure> GetSample(string spName,string json)
//        {
//            string escapedJson = json.Replace("'", "''");
//            return _context.SP_ResponseProcedure(spName, escapedJson).ToList();
//        }

//        public List<ResponseProcedure> UpdateItemWarehouseCurrentStock(string spName, string p1, int p2)
//        {
//            return _context.SP_RestoreProcedure(spName,p1,p2).ToList();
//        }

//        public List<ResponseProcedure> RestoreAeging(int p1)
//        {
//            return _context.SP_RestoreAeging(p1).ToList();
//        }

//        public List<ResponseProcedure> RestoreSalesOrder(int p1)
//        {
//            return _context.SP_RestoreSalesOrder(p1).ToList();
//        }


//        public List<ResponseProcedure> RestorePackage(int p1)
//        {
//            return _context.RestorePackage(p1).ToList();
//        }

//        public List<ResponseProcedure> GetPageDetails(string type,int Id)
//        {
//            return _context.SP_GetPageDetails(type,Id).ToList();
//        }
//    }
//}
