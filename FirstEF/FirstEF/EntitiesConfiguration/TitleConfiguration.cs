using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstEF.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstEF.EntitiesConfiguration
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(e => e.Id);
            builder.Property(p => p.Id).HasColumnName("TitleID").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
