using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Person;

[Table("person_contact", Schema = "person")]
public class PersonContact : BaseModel
{
    public Guid Id { get; set; }
    
    public PersonContact() {}
}