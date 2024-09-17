using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Legal;

[Table("company", Schema = "legal")]
public class Company : BaseModel
{
    [Column("id")]
    public Guid Id { get; init; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("status")]
    public int Status { get; set; }
    
    [Column("approved")]
    public bool Approved { get; set; }
    
    [NotMapped]
    public int CompanyId  { get; set; }
    
    public Company() {}
}