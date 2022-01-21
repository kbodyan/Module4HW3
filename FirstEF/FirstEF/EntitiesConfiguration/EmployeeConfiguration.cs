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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeID").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.HireDate).IsRequired();
            builder.Property(p => p.OfficeId).IsRequired();
            builder.HasOne(p => p.Office).WithMany(p => p.Employees).HasForeignKey(p => p.OfficeId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.TitleId).IsRequired();
            builder.HasOne(p => p.Title).WithMany(p => p.Employees).HasForeignKey(p => p.TitleId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
