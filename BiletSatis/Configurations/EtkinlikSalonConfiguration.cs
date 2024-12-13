using BiletSatis.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Configurations
{
    internal class EtkinlikSalonConfiguration : BaseEntityConfiguration<EtkinlikSalon>
    {
        public override void Configure(EntityTypeBuilder<EtkinlikSalon> builder)
        {

            builder.Property(x => x.OlusturmaTarihi).IsRequired();
            builder.Property(x => x.BitisTarihi).IsRequired();

                

            base.Configure(builder);
        }
    }
}
