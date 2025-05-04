using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Country : Base
    {        
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
         
        [MaxLength(100)]         
        public string? Language { get; set; }
                
        [MaxLength(100)]
        public string? CountryCode { get; set; }          
        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency? Currency { get; set; }
       
        public int? TaxTypeId { get; set; }
        [ForeignKey(nameof(TaxTypeId))]
        public virtual TaxType? TaxType { get; set; }      

    }
}
