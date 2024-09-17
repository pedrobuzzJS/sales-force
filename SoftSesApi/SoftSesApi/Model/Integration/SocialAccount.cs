using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Integration;

[Table("social_account", Schema = "integration")]
public class SocialAccount : BaseModel
{
    public Guid Id { get; set; }
}