using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BiletSatis.Entities.Base;


namespace BiletSatis.Entities
{
    public class Bilet : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi{ get; set; }
        public bool Indirim { get; set; } = false;
        public virtual Etkinlik Etkinlik { get; set; }
        public Guid  EtkinlikId { get; set; }
    }
}
