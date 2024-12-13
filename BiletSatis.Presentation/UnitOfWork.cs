using BiletSatis.DataServices.Concretes;
using BiletSatis.DataServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Presentation
{
     public class UnitOfWork
    {
        private static UnitOfWork instance;
        public static UnitOfWork Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitOfWork();
                }
                return instance;
            }
        }

        public IEtkinlikDataService Etkinlikler
        { get 
            {
                return new EtkinlikDataService();
            }
        }
        public IBiletDataService Biletler
        {
            get
            {
                return new BiletDataService();
            }
        }
        public ISalonDataService Salonlar
        {
            get
            {
                return new SalonDataService();
            }
        }
        public IEtkinlikSalonDataService EtkinlikSalon
        {
            get
            {
                return new EtkinlikSalonDataService();
            }
        }

    }
}
