using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon2.model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyili { get; set; }

        public Kitap()
        {

        }
        public Kitap(int kitapid,string kitapisim,string kitapyazar,string kitapdili,string yayinevi,string tur,int adet,int sayfasayisi,int basimyili)
        {
            this.kitapdili = kitapdili;
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapyazar = kitapyazar;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyili = basimyili;
        }
        public int getkitapid()
        {
            return this.kitapid;
        }
        public string getkitapisim()
        {
            return this.kitapisim;
        }
        public string getkitapdili()
        {
            return this.kitapdili;
        }
       public string getkitapyazar()
        {
            return this.kitapyazar;
        }
       public string getyayinevi()
        {
            return this.yayinevi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayisi()
        {
            return this.sayfasayisi;
        }
        public int getbasimyili()
        {
            return this.basimyili;
        }


    }
}
