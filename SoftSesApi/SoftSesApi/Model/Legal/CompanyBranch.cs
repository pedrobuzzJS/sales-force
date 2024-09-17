using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Legal;

[Table("company_branch", Schema = "legal")]
public class CompanyBranch : BaseModel
{
    public Guid Id { get; set; }
    
    public CompanyBranch() {}
}