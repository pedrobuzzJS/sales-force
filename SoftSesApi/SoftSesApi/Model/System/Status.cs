using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.System;

[Table("status", Schema = "system")]
public class Status : BaseModel
{
    public Guid Id { get; set; }
    
    public Status() {}
}