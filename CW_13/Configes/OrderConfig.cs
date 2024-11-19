using CW_13.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13.Configes
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(i => i.OrderId);
            builder.Property(i => i.CustomerId).HasColumnType("nchar(5)");
            builder.Property(i => i.ShipName).HasMaxLength(40);
            builder.Property(i => i.ShipAddress).HasMaxLength(60);
            builder.Property(i => i.ShipCity).HasMaxLength(15);
            builder.Property(i => i.ShipRegion).HasMaxLength(15);
            builder.Property(i => i.ShipPostalCode).HasMaxLength(10);
            builder.Property(i => i.ShipCountry).HasMaxLength(15);
            builder.HasOne(x=>x.Employee).WithMany(x => x.Orders).HasForeignKey(x => x.EmployeeId);
            builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Employee).WithMany(x => x.Orders).HasForeignKey(x => x.EmployeeId);

        }
    }
}
