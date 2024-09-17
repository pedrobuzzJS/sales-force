using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.System;

[Table("media", Schema = "system")]
public class Media : BaseModel
{
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("module_type")]
    public string ModuleType { get; set; }
    
    [Column("module_id")]
    public string ModuleId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("file_name")]
    public string FileName { get; set; }
    
    [Column("file_directory")]
    public string FileDirectory { get; set; }
    
    [Column("file_extension")]
    public string FileExtension { get; set; }
    
    [Column("mime_type")]
    public string MimeType { get; set; }
    
    [Column("disk")]
    public string Disk { get; set; }
    
    [Column("virtual")]
    public bool Virtual { get; set; }
    
    [Column("dimension")]
    public string Dimension { get; set; }
    
    [Column("file_size")]
    public string FileSize { get; set; }
    
    public Media() {}
}