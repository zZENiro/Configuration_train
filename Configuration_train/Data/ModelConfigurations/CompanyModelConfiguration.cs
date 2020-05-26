using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration_train.Data.ModelConfigurations
{
    public class CompanyModelConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company_tbl")
                   .HasKey(key => key.Id)
                   .HasName("comp_id");

            builder.Property(nameProp => nameProp.Name)
                   .IsRequired(true);

            builder.HasOne(c => c.Country)
                   .WithMany(c => c.Companies)
                   .HasForeignKey("county_id");

            builder.HasOne(c => c.City)
                   .WithMany(c => c.Companies)
                   .HasForeignKey("city_id");
        }
    }

}
