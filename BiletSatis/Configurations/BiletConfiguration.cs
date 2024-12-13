using BiletSatis.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Configurations
{
    public class BiletConfiguration : BaseEntityConfiguration<Bilet>
    {
        public override void Configure(EntityTypeBuilder<Bilet> builder)
        {
            builder.Property(x => x.Cinsiyet).IsRequired();
            builder.Property(x => x.AdSoyad).IsRequired().HasMaxLength(120);
            builder.Property(x => x.DogumTarihi).IsRequired();
            builder.Property(x => x.Indirim).IsRequired();
            builder.Property(x => x.Telefon).IsRequired(false);


            base.Configure(builder); // En son git basedekileri de configure et
        }
    }
}
