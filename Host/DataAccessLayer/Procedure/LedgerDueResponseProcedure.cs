using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Procedure
{
    public class LedgerDueResponseProcedure
    {
        public int? ID { get; set; }

        public string? Name { get; set; }

        public string? BillNo { get; set; }


        public DateTime? DueDate { get; set; }
        public DateTime? BillDate { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? OutStandingAmount { get; set; }

        public string? type { get; set; }

    }
}
