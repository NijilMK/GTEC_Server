using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.General.Masters
{
    public class Routes : BaseCompany
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }         
         
        public int? DistrictId { get;set; }
        [ForeignKey(nameof(DistrictId))]
        public virtual District? District { get; set; }        
         
        public int? AreaId { get; set; }
        [ForeignKey(nameof(AreaId))]
        public virtual Area? Area { get; set; }
       
    }
}
