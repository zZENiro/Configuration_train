using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration_train.Data.ModelConfigurations
{
    public class CountryModelConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country_tbl")
                   .HasKey(k => k.Id)
                   .HasName("country_id");

            builder.Property(prop => prop.CountryName)
                   .IsRequired(true);

            builder.Property(prop => prop.FlagUrl)
                   .IsRequired(true);

            builder.HasMany<Company>()
                   .WithOne(c => c.Country);
        }
    }

}
