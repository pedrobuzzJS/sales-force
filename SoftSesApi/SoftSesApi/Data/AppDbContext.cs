using Microsoft.EntityFrameworkCore;
using SoftSesApi.Model.Admin;
using SoftSesApi.Model.Document;
using SoftSesApi.Model.Event;
using SoftSesApi.Model.Financial;
using SoftSesApi.Model.Integration;
using SoftSesApi.Model.Legal;
using SoftSesApi.Model.Person;
using SoftSesApi.Model.System;

namespace SoftSesApi.Data;

public class AppDbContext : DbContext
{
    // ADMIN
    public DbSet<Message> Messages { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<RolePermission> RolePermission { get; set; }
    public DbSet<User> User { get; set; }
    
    // DOCUMENT
    public DbSet<DocumentSignature> DocumentSignatures { get; set; }
    public DbSet<DocumentTemplate> DocumentTemplate { get; set; }
    
    // EVENT
    public DbSet<Event> Events { get; set; }
    
    // FINANCIAL
    public DbSet<PaymentMethod> PaymentMethod { get; set; }
    
    // INTEGRATION
    public DbSet<SocialAccount> SocialAccount { get; set; }
    public DbSet<Webhook> Webhook { get; set; }
    
    // LEGAL
    public DbSet<Company> Company { get; set; }
    public DbSet<CompanyBranch> CompanyBranch { get; set; }
    
    // PERSON
    public DbSet<Lead> Lead { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<PersonAddress> PersonAddress { get; set; }
    public DbSet<PersonContact> PersonContact { get; set; }
    
    // SYSTEM
    public DbSet<Config> Config { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Module> Module { get; set; }
    public DbSet<Routes> Route { get; set; }
    public DbSet<Status> Status { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ss_master;Username=postgres;Password=postgres;");
        base.OnConfiguring(optionsBuilder);
    }
}