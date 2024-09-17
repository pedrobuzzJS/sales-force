using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Person;

[Table("person_address", Schema = "person")]
public class PersonAddress : BaseModel
{
    public Guid Id { get; set; }
    
    public PersonAddress() {}
}