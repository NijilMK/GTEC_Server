using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.General.Masters
{
    public class CompanySettings :BaseCompany
    {
        [Required]
        public bool IsMultipleWarehouse { get; set; }  

        public int? CurrencyId { get; set; }

        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency? Currency { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Language { get; set; } 

        public int? TaxTypeId { get; set; }

        [ForeignKey(nameof(TaxTypeId))]
        public virtual TaxType? TaxType { get; set; }

        public bool? IsMultipleBranch { get; set; }

        public string? TaxNumber { get; set; }

        public string? MastersFetchFrom { get; set; }
    }
}
