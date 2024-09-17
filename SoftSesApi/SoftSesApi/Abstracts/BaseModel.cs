using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Data;

namespace SoftSesApi.Abstracts;

public class BaseModel
{
    [Column("company_id")]
    public int CompanyId  { get; set; }
    
    [Column("metadata")]
    public string Metadata { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }
    
    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    public BaseModel()
    {
        CreatedAt = DateTime.Now;
    }
}