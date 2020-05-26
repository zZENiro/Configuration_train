using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration_train.Data.ModelConfigurations
{
    internal class EmployeeModelConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee_tbl")
                   .HasKey(k => k.Id)
                   .HasName("employee_id");

            builder.Property(prop => prop.FirstName)
                   .IsRequired(true);

            builder.Property(prop => prop.SecondName)
                   .IsRequired(true);

            builder.HasOne(e => e.Company)
                   .WithMany(c => c.Employees)
                   .HasForeignKey("company_id");

            builder.HasOne(e => e.Country)
                   .WithMany(c => c.Employees)
                   .HasForeignKey("country_id");

            builder.HasOne(e => e.City)
                   .WithMany(c => c.Employees)
                   .HasForeignKey("city_id");
        }
    }
}