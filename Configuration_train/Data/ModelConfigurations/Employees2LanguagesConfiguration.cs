using Configuration_train.Data.ManyToManyEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ModelConfigurations
{
    public class Employees2LanguagesConfiguration : IEntityTypeConfiguration<Employees2Languages>
    {
        public void Configure(EntityTypeBuilder<Employees2Languages> builder)
        {
            builder.HasOne(e => e.Employee)
                   .WithMany(el => el.Employees2Languages)
                   .HasForeignKey(fk => fk.EmployeeId);

            builder.HasOne(l => l.Language)
                   .WithMany(el => el.Employees2Languages)
                   .HasForeignKey(fk => fk.LanguageId);

            builder.ToTable("employees_lang_conns")
                   .HasKey(el => new { el.LanguageId, el.EmployeeId });
        }
    }
}
