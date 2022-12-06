using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace Repository
{
    public class  RepositoryContext :DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        DbSet<Project> Projects { get; set; }
        DbSet<Employee> Employees { get; set; }

    }
}