using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.System;

[Table("menu", Schema = "system")]
public class Menu : BaseModel
{
    public Guid Id { get; init; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("parameters")]
    public string? Parameters { get; set; }
    
    [Column("route")]
    public string? Route { get; set; }
    
    [Column("icon")]
    public string? Icon { get; set; }
    
    [Column("parent_id")]
    public int? ParentId { get; set; }
    
    [Column("has_children")]
    public bool? HasChildren { get; set; }
    
    [Column("order")]
    public int Order { get; set; }
    
    [Column("disabled")]
    public bool Disabled { get; set; }

    public Menu()
    {
        Id = Guid.NewGuid();
    }
}