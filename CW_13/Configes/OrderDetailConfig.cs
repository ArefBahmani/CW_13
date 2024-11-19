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
    public class OrderDetailConfig : IEntityTypeConfiguration<Order_Detail>
    {
        public void Configure(EntityTypeBuilder<Order_Detail> builder)
        {
            builder.HasKey(pc => new { pc.OrderID, pc.ProductID });
        }
    }
}
