using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Integration;

[Table("webhook", Schema = "integration")]
public class Webhook : BaseModel
{
    public Guid Id { get; set; }
}