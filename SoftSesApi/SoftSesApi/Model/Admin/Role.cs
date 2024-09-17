using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Admin;

[Table("role" ,Schema = "admin")]
public class Role : BaseModel
{
    [Column("id")]
    public int Id { get; init; }
    
    [Column("name")]
    public string Name { get; set; }

    public List<RolePermission> RolePermissions { get; } = [];
    //public List<Permission> Permissions { get; } = [];
    
    public Role() {}
}