using DataAccessLayer.General.Masters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DataAccessLayer;
public class Base
{
    [Key]
    public int Id { get; set; }
    //[Required] 
    //public Guid MainId { get; set; } 
    public bool IsDeleted { get; set; }
    //public DateTime CreatedDate { get; set; } 
    //public DateTime UpdatedDate { get; set; }
    //public int? CreatedBy {  get; set; }

}
public class BaseCompany : Base
{
    //public int ReferenceId { get; set; }

    //[MaxLength(100)]
    //public string? ReferenceType { get; set; }
    //public int CompanyId { get; set; }
    //[ForeignKey(nameof(CompanyId))]
    //public virtual Company? Company { get; set; }

}
