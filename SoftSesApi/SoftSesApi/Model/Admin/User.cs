using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Admin;

[Table("user", Schema = "admin")]
public class User : BaseModel
{
    [Column("id")]
    public Guid Id { get; init; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name { get; set; }
    
    [Column("user_name")]
    public string UserName { get; set; }
    
    [Column("email")]
    public string Email { get; set; }
    
    [Column("email_confirmed")]
    public bool EmailConfirmed { get; set; }
    
    [Column("password")]
    public string Password { get; set; }
    
    [Column("password_salt")]
    public string PasswordSalt { get; set; }
    
    [Column("first_login")]
    public bool FirstLogin { get; set; }
    
    [Column("foece_password_reset")]
    public bool ForcePasswordReset { get; set; }
    
    [Column("avatar")]
    public string Avatar { get; set; }
    
    [Column("token")]
    public string Token { get; set; }
    
    [Column("refresh_token")]
    public string RefreshToken { get; set; }
    
    [Column("facebook_id")]
    public string FacebookId { get; set; }
    
    [Column("google_id")]
    public string GoogleId { get; set; }
    
    [Column("status")]
    public int Status { get; set; }
    
    [Column("user_type")]
    public int UserType { get; set; }
    
    [Column("approved")]
    public bool Approved { get; set; }
    
    [Column("first_period_in")]
    public DateTime FirstPeriodIn { get; set; }
    
    [Column("first_period_out")]
    public DateTime FirstPeriodOut { get; set; }
    
    [Column("second_period_in")]
    public DateTime SecondPeriodIn { get; set; }
    
    [Column("second_period_out")]
    public DateTime SecondPeriodOut { get; set; }
    
    public User(string name)
    {
        Id = Guid.NewGuid();;
        Name = name;
    }
}