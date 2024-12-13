using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Presentation.VMs
{
    public class SalonVM
    {
        public Guid ID { get; set; }
        public int Kapasite { get; set; }

        public string Ad { get; set; }
    }
}
