using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiletSatis.Entities.Base;

namespace BiletSatis.Entities;

public class Salon : BaseEntity
{
    public string Adı { get; set; }

    public int Kapasite { get; set; }

    public virtual List<EtkinlikSalon> EtkinlikSalon { get; set; }
}
