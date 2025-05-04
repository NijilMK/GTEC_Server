using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Procedure
{
    public class FinantialReportResponseProcedure
    {
        public int? ID { get; set; }

        public string? Ledger { get; set; }

        public string? GroupAccount { get; set; }

        public string? SubAccount { get; set; }

        public string? MainAccount { get; set; }


        public decimal? Balance { get; set; }

        public decimal? OpenStock { get; set; }

        public decimal? ClosingStock { get; set; }

    }
}
