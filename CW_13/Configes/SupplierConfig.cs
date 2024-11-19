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
    internal class SupplierConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.SupplierId);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.ContactName).HasMaxLength(30);
            builder.Property(x => x.ContactTitle).HasMaxLength(30);
            builder.Property(x => x.Address).HasMaxLength(60);
            builder.Property(x => x.City).HasMaxLength(15);
            builder.Property(x => x.Region).HasMaxLength(15);
            builder.Property(x => x.PostalCode).HasMaxLength(10);
            builder.Property(x => x.Country).HasMaxLength(15);
            builder.Property(x => x.Phone).HasMaxLength(24);
            builder.Property(x => x.Fax).HasMaxLength(24);
        }
    }
}
