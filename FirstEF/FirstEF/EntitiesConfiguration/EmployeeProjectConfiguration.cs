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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeProjectID").ValueGeneratedOnAdd();
            builder.Property(p => p.Rate).IsRequired();
            builder.Property(p => p.StartedDate).IsRequired();
            builder.Property(p => p.EmployeeID).IsRequired();
            builder.HasOne(p => p.Employee).WithMany(p => p.EmployeeProjects).HasForeignKey(p => p.EmployeeID).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.ProjectId).IsRequired();
            builder.HasOne(p => p.Project).WithMany(p => p.EmployeeProjects).HasForeignKey(p => p.ProjectId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
