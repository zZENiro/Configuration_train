using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ModelConfigurations
{
    public class CityModelConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city_tbl")
                   .HasKey(key => key.Id)
                   .HasName("city_id");

            builder.Property(prop => prop.CityName)
                   .IsRequired(true);

            builder.HasMany(prop => prop.Companies)
                   .WithOne(prop => prop.City)
                   .HasForeignKey("comp_id");
        }
    }
}
