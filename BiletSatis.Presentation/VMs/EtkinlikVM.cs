using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Presentation.VMs
{
    public class EtkinlikVM
    {
        public Guid Id { get; set; }

        public string Adı { get; set; }
        public int YasSiniri { get; set; } 

        public double BiletUcreti { get; set; }

        public DateTime BaslangicZamanı { get; set; }
        public DateTime BitisZamanı { get; set; }
        public int  BiletSayısı { get; set; }
        public string SalonAdi { get; set; }

    }
}
