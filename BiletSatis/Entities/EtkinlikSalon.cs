using BiletSatis.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Entities;

public class EtkinlikSalon :BaseEntity
{

    public DateTime BaslangicTarihi { get; set; }
    public DateTime BitisTarihi { get; set; }
    public Guid SalonId { get; set; }

    public virtual Salon Salon { get; set; }


    public Guid EtkinlikId { get; set; }

    public virtual Etkinlik Etkinlik { get; set; }
   


   
}
