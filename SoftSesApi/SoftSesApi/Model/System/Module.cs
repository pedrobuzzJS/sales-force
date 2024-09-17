using System.ComponentModel.DataAnnotations.Schema;

namespace SoftSesApi.Model.System;

[Table("module", Schema = "system")]
public class Module
{
    public Guid Id { get; set; }
    
    public Module() {}
}