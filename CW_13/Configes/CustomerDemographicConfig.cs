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
    public class CustomerDemographicConfig : IEntityTypeConfiguration<CustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographic> builder)
        {
            builder.HasKey(i=>i.CustomerTypeId);
            builder.Property(i => i.CustomerTypeId).IsRequired().HasColumnType("nchar(10)");
           
        }
    }
}
