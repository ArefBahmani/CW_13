using CW_13.Entityes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13.Configes
{
    public class CustomerCustomerDemoConfig : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasKey(pc => new { pc.CustomerId, pc.CustomerTypeId });
            
            builder.Property(p => p.CustomerId).IsRequired().HasColumnType("nchar(5)");
            
            builder.Property(p => p.CustomerTypeId).IsRequired().HasColumnType("nchar(10)");

        }
    }
}

