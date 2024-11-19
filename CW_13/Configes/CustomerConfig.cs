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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(i => i.CustomerId);
            builder.Property(p => p.CustomerId).IsRequired().HasColumnType("nchar(5)");
            builder.Property(m => m.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(m => m.ContactName).HasMaxLength(30);
            builder.Property(m => m.ContactTitle).HasMaxLength(30);
            builder.Property(m => m.Address).HasMaxLength(60);
            builder.Property(m => m.City).HasMaxLength(15);
            builder.Property(m => m.Region).HasMaxLength(15);
            builder.Property(m => m.PostalCode).HasMaxLength(10);
            builder.Property(m => m.Country).HasMaxLength(15);
            builder.Property(m => m.Phone).HasMaxLength(24);
            builder.Property(m => m.Fax).HasMaxLength(24);

        }
    }
}
