using DataAccessLayer.General.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inventory
{
    public class ItemTransfer : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Invoice { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? EwayDate { get; set; }

        [MaxLength(100)]
        public string? EwayNumber { get; set; }

        public int? FromId { get; set; }

        [MaxLength(100)]
        public string? Reference { get; set; }

        public DateTime? ReferenceDate { get; set; }

        [MaxLength(100)]
        public string? TransportMode { get;set; }

        [MaxLength(100)]
        public string? VehicleNumber { get; set; }

        [MaxLength(100)]
        public string? Purpose { get; set; }

        [MaxLength(100)]
        public string? Place { get; set; }
        public bool? Published { get; set; }
        public bool? IsUnit { get; set; }

        public int? BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch? Branch { get; set; }


    }
}
