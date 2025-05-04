using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Vehicle : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? VehicleNumber { get; set; }

        public int? Driver { get; set; }

        public int? FreeCode { get; set; }

        public int? FreeCode2 { get; set; }

        [MaxLength(100)]
        public string? ContactPerson { get; set; }             

    }
}
