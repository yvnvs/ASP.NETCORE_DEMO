using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options) 
        {

        }

        DbSet<Project> Projects { get; set; }
        DbSet<Employee> Employees { get; set; }

    }
}