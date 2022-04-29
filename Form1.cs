using KütüphaneOtomasyon2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon2
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower()==kisi.getKullaniciadi() && sifre.ToLower()==kisi.getSifre() && kisi.getYetki()=="admin")
                {
                    //admin sayfasına yönlendir
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getKullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    //üye sayfasına yönlendir
                    UyeSayfasi uyeSayfasi = new UyeSayfasi();
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
        
               
            }
            if (kontrol==false)
            {
                MessageBox.Show("Hatalı Giriş","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"Erdem","Engin","erdemengin","1","admin",DateTime.Now));
            kisilerim.Add(new Kisi(2,"Sinan","Kaya","sinankaya","2","uye",DateTime.Now));
            kisilerim.Add(new Kisi(3, "Hüsnü", "Çoban", "hüsnüçoban", "3", "uye", DateTime.Now));
            kisilerim.Add(new Kisi(4, "Arap", "Şükrü", "arapşükrü", "4", "uye", DateTime.Now));


            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",350,760,2015));
            kitaplarim.Add(new Kitap(3,"Uçurtma Avcısı","Khaled Hosseini","İngilizce","Everest Yayıncılık","Roman",100,350,2010));
            kitaplarim.Add(new Kitap(4,"Küçük Prens","Antoine de Saint-Exupery","İngilizce","Can Çocuk Yayınları","Roman",50,60,2018));
            kitaplarim.Add(new Kitap(5,"Kürk Mantolu Madoma","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","Roman",50,220,2015));
        
        }
    }
}
