using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Admin;

[Table("permission", Schema = "admin")]
public class Permission : BaseModel
{
    [Column("id")]
    public int Id { get; init; }
    
    [Column("name")]
    public string Nome { get; set; }

    public List<RolePermission> RolePermissions { get; } = [];
    
    [NotMapped]
    public int CompanyId  { get; set; }

    public Permission(string nome) {}
}