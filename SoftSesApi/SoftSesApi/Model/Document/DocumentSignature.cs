using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Document;

[Table("document_signature", Schema = "document")]
public class DocumentSignature : BaseModel
{
    [Column("id")]
    public Guid Id { get; set; }
    
    public DocumentSignature() {}
}