using Microsoft.EntityFrameworkCore;
using WebApi_Personas.Models;

namespace WebApi_Personas.Context
{
    public class AppDbContext : DbContext //Herencia de clase de entityFramework (ORM)
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


    public required DbSet<Person> Persons { get; set; }


    }
}
