using Microsoft.EntityFrameworkCore;
using RedeSocial.Domain.Entities;
using System.Reflection;

namespace SocialNetwork.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
