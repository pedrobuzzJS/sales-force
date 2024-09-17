using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Admin;

[Table("message", Schema = "admin")]
public class Message : BaseModel
{
    [Column("id")]
    public Guid Id { get; init; }
    
    [Column("type")]
    public string Type { get; set; }
    
    [Column("sent_at")]
    public DateTime SentAt { get; init; }
    
    [Column("html")]
    public string Html { get; set; }
    
    [Column("status")]
    public string Status { get; init; }

    public Message() {}
}