using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Procedure
{
    public class TrailBalanceResponseProcedure
    {
        public int? ID { get; set; }

        public string? MainAccount { get; set; }

        public string? Ledger { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Openning { get; set; }

        public decimal? Closing { get; set; }

        public decimal? OpenStock { get; set; }
        public decimal? ClosingStock
        {
            get; set;




        }
    }
}
