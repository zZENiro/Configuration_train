using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration_train.Data.ModelConfigurations
{
    public class LanguageModelConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("lang_tbl")
                   .HasKey(k => k.Id)
                   .HasName("lang_id");

            builder.Property(prop => prop.LanguageName)
                   .IsRequired(true);
        }
    }

}
