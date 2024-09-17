using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Person;

[Table("lead", Schema = "person")]
public class Lead : BaseModel
{
    public Guid Id { get; set; }
    
    public Lead() {}
}