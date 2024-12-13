using BiletSatis.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Configurations
{
    internal class SalonConfiguration :BaseEntityConfiguration<Salon>
    {
        public override void Configure(EntityTypeBuilder<Salon> builder)
        {
            builder.Property(x => x.Adı).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Kapasite).IsRequired();

            base.Configure(builder);
        }
    }
}
