using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Procedure
{
    public class ReportResponseProcedure
    {
        public int? ID { get; set; }

        public string?  Name { get; set; }

        public DateTime? TransactionDate { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Openning {  get; set; }

        public string Narration { get; set; }

    }
}
