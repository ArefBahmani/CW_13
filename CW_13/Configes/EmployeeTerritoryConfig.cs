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
    internal class EmployeeTerritoryConfig : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.HasKey(pc => new { pc.EmployeeId, pc.TerritoryId });
            builder.Property(i => i.TerritoryId).IsRequired().HasMaxLength(20);
            builder.HasOne(x => x.Territory).WithMany(y => y.EmployeeTerritories).HasForeignKey(x=>x.TerritoryId);
            builder.HasOne(x=>x.Employee).WithMany(y=>y.EmployeeTerritories).HasForeignKey(y=>y.EmployeeId);


        }
    }
}
