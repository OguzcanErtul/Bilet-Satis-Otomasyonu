using BiletSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Presentation.VMs
{
    public class BiletVM
    {
        public Guid Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Indirim { get; set; } = false;
        
        public string  EtkinlikAdi { get; set; }

        public string SalonAdi { get; set; }
        public double  Ucret { get; set; }
        public DateTime BaslangicZamani { get; set; }

        public TimeSpan EtkinlikSuresi { get; set; }

    }
}
