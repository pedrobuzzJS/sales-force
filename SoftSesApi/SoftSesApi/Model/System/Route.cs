using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.System;

[Table("route", Schema = "system")]
public class Routes : BaseModel
{
    [Column("id")]
    public Guid Id { get; set; }
    
    public Routes() {}
}