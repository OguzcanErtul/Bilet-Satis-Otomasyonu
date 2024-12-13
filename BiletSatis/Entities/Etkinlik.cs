using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiletSatis.Entities.Base;

namespace BiletSatis.Entities;

public class Etkinlik : BaseEntity
{
    public string Adı {  get; set; }

    public int YasSiniri { get; set; } = 0;

    public double BiletUcreti { get; set; }

    public virtual List<EtkinlikSalon> EtkinlikSalon { get; set; }
    public virtual List<Bilet> Biletler { get; set; }
}
