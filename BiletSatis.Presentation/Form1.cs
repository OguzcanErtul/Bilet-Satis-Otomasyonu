using BiletSatis.Context;
using BiletSatis.Entities;
using BiletSatis.Presentation.VMs;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BiletSatis.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Salonlar�Getir();
            SalonAlan�n�Temizle();
            EtkinlikleriGetir();
            EtkinlikAlan�n�Temizle();
            BiletleriGetir();
        }

        Guid guncellenecekSalonId;
        Guid guncellenecekEtkinlikId;
        Guid guncellenecekBiletId;
        private void BiletleriGetir()
        {
            dgw_bilet.DataSource = null;
            var biletler = UnitOfWork.Instance.Biletler.GetAll();
            List<BiletVM> biletlerVM = new List<BiletVM>();

            foreach (var bilet in biletler)
            {
                var salonEtkinlik = UnitOfWork.Instance.EtkinlikSalon.GetAll().FirstOrDefault(x => x.EtkinlikId == bilet.EtkinlikId);
                var etkinlik = UnitOfWork.Instance.Etkinlikler.GetById(bilet.EtkinlikId);
                var salon = UnitOfWork.Instance.Salonlar.GetById(salonEtkinlik.SalonId);
                BiletVM biletVM = new BiletVM()
                {
                    Id = bilet.Id,
                    AdSoyad = bilet.AdSoyad,
                    Cinsiyet = bilet.Cinsiyet,
                    DogumTarihi = bilet.DogumTarihi,
                    Telefon = bilet.Telefon,
                    Indirim = bilet.Indirim,
                    EtkinlikAdi = etkinlik.Ad�,
                    BaslangicZamani = salonEtkinlik.BaslangicTarihi,
                    Ucret = bilet.Indirim ? etkinlik.BiletUcreti * 0.9 : etkinlik.BiletUcreti,
                    SalonAdi = salon.Ad�,
                    EtkinlikSuresi = salonEtkinlik.BitisTarihi - salonEtkinlik.BaslangicTarihi
                };
                biletlerVM.Add(biletVM);
            }
            dgw_bilet.DataSource = biletlerVM;
            dgw_bilet.Columns["Id"].Visible = false;


            cmb_biletEtkinlik.DataSource = UnitOfWork.Instance.Etkinlikler.GetAll();
            cmb_biletEtkinlik.DisplayMember = "Ad�";
            cmb_biletEtkinlik.ValueMember = "Id";
            BiletAlan�n�Temizle();

        }

        private void BiletAlan�n�Temizle()
        {
            txt_BiletAdSoyad.Text = string.Empty;
            txt_telefon.Text = string.Empty;
            dtp_dogumTarihi.Value = DateTime.Now;
            chk_indirim.Checked = false;
            chk_Kad�n.Checked = true;


        }

        private void EtkinlikAlan�n�Temizle()
        {
            txt_EtkinlikAdi.Text = string.Empty;
            nud_biletUcreti.Value = 0;
            nud_yasSiniri.Value = 18;
        }

        private void EtkinlikleriGetir()
        {
            dgw_Etkinlik.DataSource = null;
            var etkinlikler = UnitOfWork.Instance.Etkinlikler.GetAll();
            List<EtkinlikVM> etkinliklerVM = new List<EtkinlikVM>();

            foreach (var etkinlik in etkinlikler)
            {
                var salonEtkinlik = UnitOfWork.Instance.EtkinlikSalon.GetAll().FirstOrDefault(x => x.EtkinlikId == etkinlik.Id);
                EtkinlikVM etkinlikVM = new EtkinlikVM()
                {
                    Id = etkinlik.Id,
                    Ad� = etkinlik.Ad�,
                    YasSiniri = etkinlik.YasSiniri,
                    BiletUcreti = etkinlik.BiletUcreti,
                    BaslangicZaman� = salonEtkinlik.BaslangicTarihi,
                    BitisZaman� = salonEtkinlik.BitisTarihi,
                    BiletSay�s� = UnitOfWork.Instance.Salonlar.GetById(salonEtkinlik.SalonId).Kapasite,
                    SalonAdi = UnitOfWork.Instance.Salonlar.GetById(salonEtkinlik.SalonId).Ad�,
                };
                etkinliklerVM.Add(etkinlikVM);
            }
            dgw_Etkinlik.DataSource = etkinliklerVM;
            dgw_Etkinlik.Columns["Id"].Visible = false;
            cmb_Salonlar.DataSource = UnitOfWork.Instance.Salonlar.GetAll();
            cmb_Salonlar.DisplayMember = "Ad�";
            cmb_Salonlar.ValueMember = "Id";
            EtkinlikAlan�n�Temizle();
        }


        private void SalonAlan�n�Temizle()
        {
            txt_SalonAdi.Text = string.Empty;
            nud_Kapasite.Value = 100;

        }



        private void Salonlar�Getir()
        {
            dgw_Salon.DataSource = null;
            var salonlar = UnitOfWork.Instance.Salonlar.GetAll();
            List<SalonVM> salonlarVM = new List<SalonVM>();

            foreach (var salon in salonlar)
            {
                SalonVM salonVM = new SalonVM()
                {
                    ID = salon.Id,
                    Kapasite = salon.Kapasite,
                    Ad = salon.Ad�,
                };
                salonlarVM.Add(salonVM);
            }
            dgw_Salon.DataSource = salonlarVM;
            dgw_Salon.Columns["Id"].Visible = false;
            SalonAlan�n�Temizle();
            EtkinlikleriGetir();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon()
            {
                Ad� = txt_SalonAdi.Text,
                Kapasite = (int)nud_Kapasite.Value,
            };

            UnitOfWork.Instance.Salonlar.Add(salon);
            Salonlar�Getir();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.Salonlar.Remove(SalonIdSec());
            Salonlar�Getir();
        }

        private Guid SalonIdSec()
        {
            return (Guid)dgw_Salon.SelectedRows[0].Cells["Id"].Value;
        }

        private void btn_G�ncelle_Click(object sender, EventArgs e)
        {
            var yeniGuncellenecekSalon = UnitOfWork.Instance.Salonlar.GetById(guncellenecekSalonId);
            yeniGuncellenecekSalon.Ad� = txt_SalonAdi.Text;
            yeniGuncellenecekSalon.Kapasite = (int)nud_Kapasite.Value;
            UnitOfWork.Instance.Salonlar.Update(yeniGuncellenecekSalon);
            Salonlar�Getir();


        }

        private void g�ncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncellenecekSalonId = SalonIdSec();
            var guncellenecekSalon = UnitOfWork.Instance.Salonlar.GetById(guncellenecekSalonId);
            txt_SalonAdi.Text = guncellenecekSalon.Ad�;
            nud_Kapasite.Value = (decimal)guncellenecekSalon.Kapasite;
        }

        private void btn_EtkinlikEkle_Click(object sender, EventArgs e)
        {
            var baslangizZamani = dtp_EtkinlikBa�lang��.Value;
            var bitisZamani = dtp_EtkinlikBiti�.Value;
            var salonId = (Guid)cmb_Salonlar.SelectedValue;
            var etkinlikCakisma = UnitOfWork.Instance.EtkinlikSalon.GetAll().
                Any(x => ((baslangizZamani >= x.BaslangicTarihi && baslangizZamani < x.BitisTarihi) ||
                        (bitisZamani > x.BaslangicTarihi && bitisZamani <= x.BitisTarihi) ||
                        (baslangizZamani <= x.BaslangicTarihi && bitisZamani >= x.BitisTarihi)) &&
                        x.SalonId == salonId

                        );

            if (etkinlikCakisma || !(dtp_EtkinlikBiti�.Value > dtp_EtkinlikBa�lang��.Value))
            {
                MessageBox.Show("Etkinli�i Ekleyemezsiniz");
            }
            else
            {
                Etkinlik etkinlik = new Etkinlik()
                {
                    Ad� = txt_EtkinlikAdi.Text,
                    YasSiniri = (int)nud_yasSiniri.Value,
                    BiletUcreti = (double)nud_biletUcreti.Value,
                };

                UnitOfWork.Instance.Etkinlikler.Add(etkinlik);
                EtkinlikSalon salonEtkinlik = new EtkinlikSalon()
                {
                    EtkinlikId = etkinlik.Id,
                    SalonId = (Guid)cmb_Salonlar.SelectedValue,
                    BaslangicTarihi = dtp_EtkinlikBa�lang��.Value,
                    BitisTarihi = dtp_EtkinlikBiti�.Value,

                };
                UnitOfWork.Instance.EtkinlikSalon.Add(salonEtkinlik);
                EtkinlikleriGetir();

            }

        }

        private void silEtkinlikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var etkinlikId = EtkinlikIdSec();
            var result = UnitOfWork.Instance.Biletler.GetAll().Any(x => x.EtkinlikId == etkinlikId);
            if (result)
            {
                MessageBox.Show("Etkinli�i bilet sat��� oldu�in silme i�lemi yapmazs�n�z");
            }
            else
            {

                UnitOfWork.Instance.Etkinlikler.Remove(etkinlikId);
                var silinecekSalonEtkinlik = UnitOfWork.Instance.EtkinlikSalon.GetAll().FirstOrDefault(x => x.EtkinlikId == etkinlikId);
                UnitOfWork.Instance.EtkinlikSalon.Remove(silinecekSalonEtkinlik.Id);
                EtkinlikleriGetir();

            }
        }

        private Guid EtkinlikIdSec()
        {
            return (Guid)dgw_Etkinlik.SelectedRows[0].Cells["Id"].Value;
        }
        private void g�ncelleEtkinlikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guncellenecekEtkinlikId = EtkinlikIdSec();
            var guncellenecekEtkinlik = UnitOfWork.Instance.Etkinlikler.GetById(guncellenecekEtkinlikId);
            var guncellenecekSalonEtkinlik = UnitOfWork.Instance.EtkinlikSalon.GetAll().FirstOrDefault(x => x.EtkinlikId == guncellenecekEtkinlikId);

            txt_EtkinlikAdi.Text = guncellenecekEtkinlik.Ad�;
            nud_biletUcreti.Value = (decimal)guncellenecekEtkinlik.BiletUcreti;
            nud_yasSiniri.Value = (int)guncellenecekEtkinlik.YasSiniri;
            cmb_Salonlar.SelectedItem = guncellenecekSalonEtkinlik.SalonId;
            dtp_EtkinlikBa�lang��.Value = guncellenecekSalonEtkinlik.BaslangicTarihi;
            dtp_EtkinlikBiti�.Value = guncellenecekSalonEtkinlik.BitisTarihi;
        }

        private void btn_EtkinlikG�ncelle_Click(object sender, EventArgs e)
        {
            var yeniGuncellenecekEtkinlik = UnitOfWork.Instance.Etkinlikler.GetById(guncellenecekEtkinlikId);
            var yeniguncellenecekSalonEtkinlik = UnitOfWork.Instance.EtkinlikSalon.GetAll().FirstOrDefault(x => x.EtkinlikId == guncellenecekEtkinlikId);
            yeniGuncellenecekEtkinlik.Ad� = txt_EtkinlikAdi.Text;
            yeniGuncellenecekEtkinlik.BiletUcreti = (int)nud_biletUcreti.Value;
            yeniGuncellenecekEtkinlik.YasSiniri = (int)nud_yasSiniri.Value;
            yeniguncellenecekSalonEtkinlik.BaslangicTarihi = dtp_EtkinlikBa�lang��.Value;
            yeniguncellenecekSalonEtkinlik.BitisTarihi = dtp_EtkinlikBiti�.Value;
            yeniguncellenecekSalonEtkinlik.SalonId = (Guid)cmb_Salonlar.SelectedValue;

            UnitOfWork.Instance.EtkinlikSalon.Update(yeniguncellenecekSalonEtkinlik);
            UnitOfWork.Instance.Etkinlikler.Update(yeniGuncellenecekEtkinlik);
            EtkinlikleriGetir();
        }

        private void btn_biletEkle_Click(object sender, EventArgs e)
        {
            var biletEtkinligi = UnitOfWork.Instance.Etkinlikler.GetAll().FirstOrDefault(x => x.Id == (Guid)cmb_biletEtkinlik.SelectedValue);
            int yasSiniri = DateTime.Now.Year - dtp_dogumTarihi.Value.Year;
            bool satinAlabilirMi = yasSiniri >= biletEtkinligi.YasSiniri;
            if (satinAlabilirMi)
            {
                Bilet eklenecekBilet = new Bilet()
                {
                    AdSoyad = txt_BiletAdSoyad.Text,
                    Telefon = txt_telefon.Text,
                    Cinsiyet = chk_erkek.Checked ? false : true,
                    DogumTarihi = dtp_dogumTarihi.Value,
                    Indirim = chk_indirim.Checked,
                    EtkinlikId = (Guid)cmb_biletEtkinlik.SelectedValue,
                };
                UnitOfWork.Instance.Biletler.Add(eklenecekBilet);
                BiletleriGetir();

            }
            else
            {
                MessageBox.Show("Ya� S�n�r�na Tak�ld�n�z");
            }
        }

        private void s�LBiletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.Biletler.Remove(BiletIdSec());
            BiletleriGetir();
        }

        private Guid BiletIdSec()
        {
            return (Guid)dgw_bilet.SelectedRows[0].Cells["Id"].Value;

        }

        private void g�NCELLEBiletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guncellenecekBiletId = BiletIdSec();
            var guncellenecekBilet = UnitOfWork.Instance.Biletler.GetById(guncellenecekBiletId);
            txt_BiletAdSoyad.Text = guncellenecekBilet.AdSoyad;
            txt_telefon.Text = guncellenecekBilet.Telefon;
            chk_indirim.Checked = guncellenecekBilet.Indirim;
            chk_Kad�n.Checked = guncellenecekBilet.Cinsiyet ? true : false;
            dtp_dogumTarihi.Value = guncellenecekBilet.DogumTarihi;
            
        }

        private void btn_biletG�ncelle_Click(object sender, EventArgs e)
        {
            var biletEtkinligi = UnitOfWork.Instance.Etkinlikler.GetAll().FirstOrDefault(x => x.Id == (Guid)(cmb_biletEtkinlik.SelectedValue));

            var yasSiniri = DateTime.Now.Year - dtp_dogumTarihi.Value.Year;

            bool sat�nAlabilirMi = yasSiniri >= biletEtkinligi?.YasSiniri;

            if (sat�nAlabilirMi)
            {
                var yeniGuncellencekBilet = UnitOfWork.Instance.Biletler.GetById(guncellenecekBiletId);
                yeniGuncellencekBilet.AdSoyad = txt_BiletAdSoyad.Text;
                yeniGuncellencekBilet.Telefon = txt_telefon.Text;
                yeniGuncellencekBilet.DogumTarihi = dtp_dogumTarihi.Value;
                yeniGuncellencekBilet.Indirim = chk_indirim.Checked; 
                yeniGuncellencekBilet.Cinsiyet = chk_Kad�n.Checked ? true : false;

                UnitOfWork.Instance.Biletler.Update(yeniGuncellencekBilet);
                BiletleriGetir();
            }



        }
    }
}