using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.System;

[Table("config", Schema = "system")]
public class Config : BaseModel
{
    public Guid Id { get; set; }
    
    public Config() {}
}