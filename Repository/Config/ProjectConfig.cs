using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    Id = new Guid("edae4e44-e76c-4b47-a1a7-db79f545e88d"),
                    Name = "ASP.NET Core Web API Project",
                    Description = "Web Application Programming Interface",
                    Field = "CS",
                });
        }


    }
}
