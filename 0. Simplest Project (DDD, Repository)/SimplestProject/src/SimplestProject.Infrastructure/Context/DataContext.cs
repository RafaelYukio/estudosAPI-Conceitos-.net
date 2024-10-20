using Microsoft.EntityFrameworkCore;
using SimplestProject.Domain.Entities;

namespace SimplestProject.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
    }
}
