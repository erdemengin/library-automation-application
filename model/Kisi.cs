using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon2.model
{
   public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public DateTime olusturmatarih { get; set; }
        public string yetki { get; set; }

        public Kisi()
        {

        }
        public Kisi(int id,string isim,string soyisim,string kullaniciadi,string sifre,string yetki ,DateTime olusturmatarih)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.kullaniciadi = kullaniciadi;
            this.id = id;
            this.olusturmatarih = olusturmatarih;
            this.yetki = yetki;
            this.sifre = sifre;
        }
        public void setId(int id)
        {
            this.id = id;
        }
       public int getId()
        {
            return this.id;
        }
      public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getIsim()
        {
            return this.isim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setKullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string getKullaniciadi()
        {
            return this.kullaniciadi;
        }
        public void setOlusturmatarih(DateTime olusturmatarih)
        {
            this.olusturmatarih = olusturmatarih;
        }
        public DateTime getOlusturmatarih()
        {
            return this.olusturmatarih;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getSifre()
        {
            return this.sifre;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki;
        }
        public override string ToString()
        {
            return "İsim-Soyisim:" + this.isim + " " + this.soyisim;
        }
    }
}
