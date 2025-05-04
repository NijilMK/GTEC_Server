using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.General.Masters;

namespace DataAccessLayer.Accounting.Masters
{
    public class AccountSettings : BaseCompany
    {
        [Required]
        public string? Type { get; set; }
        public string? MainLedger { get; set; }
        public string? MainLedgerId { get; set; }

    }
}
