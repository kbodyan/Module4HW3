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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ProjectID").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired();
            builder.Property(p => p.StartedDate).IsRequired();
        }
    }
}
