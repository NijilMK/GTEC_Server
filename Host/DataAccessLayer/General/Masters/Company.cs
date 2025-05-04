using DataAccessLayer.General.Masters;
using Newtonsoft.Json;
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
    public class Company : Base
    {
        [Required]
        [MaxLength(100)]
        public string? CompanyName { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State? State { get; set; }
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Logo { get; set; }
        public int? AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public virtual Address? Address { get; set; }
    }
}
