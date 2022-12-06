using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Entities.Models.Employee>
    {

        public void Configure(EntityTypeBuilder<Entities.Models.Employee> builder)
        {
            builder.HasData(
                    new Entities.Models.Employee()
                    {
                        Id = new Guid("74d5bc00-cbeb-447b-bf17-e265ba3188f5"),
                        ProjectId = new Guid("edae4e44-e76c-4b47-a1a7-db79f545e88d"),
                        FirstName= "Yunus",
                        LastName = "İnne",
                        Age = 28,
                        Position = "Jr"
                    });
        }
    }
}
