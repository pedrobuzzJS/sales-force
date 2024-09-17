using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Document;

[Table("document_template", Schema = "document")]
public class DocumentTemplate : BaseModel
{
    [Column("id")]
    public Guid Id { get; set; }
    
    public DocumentTemplate() {}
}