using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Person;

[Table("person", Schema = "person")]
public class Person : BaseModel
{
    [Column("id")]
    public Guid Id { get; set; }
    
    public Person() {}
}