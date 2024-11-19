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
    internal class ShipperConfig : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
           builder.HasKey(x=>x.ShipperId);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Phone).HasMaxLength(24);
        }
    }
}
