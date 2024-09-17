using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Admin;

[Table("role_permission", Schema = "admin"), PrimaryKey(nameof(RoleId), nameof(PermissionId))]
public class RolePermission : BaseModel
{
    [Column("role_id")]
    public int RoleId { get; set; }
    
    [Column("permission_id")]
    public int PermissionId { get; set; }
    
    public Role Role { get; set; } = null!;
    
    public Permission Permission { get; set; } = null!;
    
    public RolePermission() {}
}