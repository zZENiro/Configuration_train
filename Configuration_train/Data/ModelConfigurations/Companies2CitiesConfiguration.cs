using Configuration_train.Data.ManyToManyEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ModelConfigurations
{
    public class Companies2CitiesConfiguration : IEntityTypeConfiguration<Companies2Cities>
    {
        public void Configure(EntityTypeBuilder<Companies2Cities> builder)
        {
            builder.HasOne(prop => prop.Company)
                   .WithMany(prop => prop.Companies2Cities)
                   .HasForeignKey(fk => fk.CompanyId);

            builder.HasOne(prop => prop.City)
                   .WithMany(prop => prop.Companies2Cities)
                   .HasForeignKey(fk => fk.CityId);

            builder.ToTable("companies_cities_conns")
                   .HasKey(k => new string[] { $"{k.CityId}", "-", $"{k.CompanyId}" });
        }
    }
}
