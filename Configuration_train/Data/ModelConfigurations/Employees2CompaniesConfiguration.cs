using Configuration_train.Data.ManyToManyEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ModelConfigurations
{
    public class Employees2CompaniesConfiguration : IEntityTypeConfiguration<Employees2Companies>
    {
        public void Configure(EntityTypeBuilder<Employees2Companies> builder)
        {
            builder.HasOne(prop => prop.Employee)
                   .WithMany(prop => prop.Employees2Companies)
                   .HasForeignKey(fk => fk.EmployeeId);

            builder.HasOne(prop => prop.Company)
                   .WithMany(prop => prop.Employees2Companies)
                   .HasForeignKey(fk => fk.CompanyId);

            builder.ToTable("employees_companies_conn")
                   .HasKey(k => $"{k.CompanyId}-{k.EmployeeId}");
        }
    }
}
