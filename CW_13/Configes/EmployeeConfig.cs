using CW_13.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CW_13.Configes
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(i => i.EmployeeId);
            builder.Property(i => i.LastName).IsRequired().HasMaxLength(20);
            builder.Property(i => i.FirstName).IsRequired().HasMaxLength(10);
            builder.Property(i => i.Title).HasMaxLength(30);
            builder.Property(i => i.TitleOfCourtesy).HasMaxLength(25);
            builder.Property(i => i.Address).HasMaxLength(60);
            builder.Property(i => i.City).HasMaxLength(15);
            builder.Property(i => i.Region).HasMaxLength(15);
            builder.Property(i => i.PostalCode).HasMaxLength(10);
            builder.Property(i => i.Country).HasMaxLength(15);
            builder.Property(i => i.HomePhone).HasMaxLength(24);
            builder.Property(i => i.Extension).HasMaxLength(4);
            builder.Property(i => i.PhotoPath).HasMaxLength(255);
            builder.HasOne(x=>x.CurrentEmployee).WithMany(y=>y.Employees).HasForeignKey(u=>u.ReportsTo);




        }
    }
}
