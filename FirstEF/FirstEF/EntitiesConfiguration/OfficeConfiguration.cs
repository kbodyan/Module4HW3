using Microsoft.EntityFrameworkCore;
using FirstEF.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstEF.EntitiesConfiguration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(e => e.Id);
            builder.Property(p => p.Id).HasColumnName("OfficeID").ValueGeneratedOnAdd();
            builder.Property(p => p.Ttitle).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Location).IsRequired().HasMaxLength(100);
        }
    }
}
