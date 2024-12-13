using BiletSatis.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.AddDatabase
{
    public class AplicationDatabase
    {
        private static AppDbContext context;

        //buradaki contexti her işlem yptığımızda newlemedik biz
        // Eğer newlemediysem null sa newlemiş olacağız
        public static AppDbContext Context 
        { 
            get 
            {
                if (context == null)
                {
                    context = new AppDbContext();
                }
                return context;
            } 
        }
    }
}
