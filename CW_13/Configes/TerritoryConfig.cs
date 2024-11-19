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
    internal class TerritoryConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(x=>x.TerritoryId);
            builder.Property(x => x.TerritoryId).HasMaxLength(20);
            builder.Property(x => x.TerritoryDescription).IsRequired().HasColumnType("nchar(50)");
            builder.Property(x => x.RegionId).IsRequired();
            builder.HasOne(x => x.Region).WithMany(y => y.Territories).HasForeignKey(x => x.RegionId);
        }
    }
}
