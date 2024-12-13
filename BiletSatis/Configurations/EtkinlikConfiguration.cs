using BiletSatis.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Configurations
{
    public class EtkinlikConfiguration : BaseEntityConfiguration<Etkinlik>
    {
        public override void Configure(EntityTypeBuilder<Etkinlik> builder)
        {
            builder.Property(x=>x.Adı).IsRequired().HasMaxLength(128);
            builder.Property(x => x.BiletUcreti).IsRequired();
            builder.Property(x=>x.YasSiniri).IsRequired();
            base.Configure(builder);
        }
    }
}
