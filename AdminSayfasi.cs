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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim , List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmatarih(), kisi.getSifre(), kisi.getYetki());
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(),kitap.getkitapisim(),kitap.getkitapdili(),kitap.getyayinevi(),kitap.gettur(),kitap.getadet(),kitap.getsayfasayisi(),kitap.getbasimyili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_kitapid.Text,txt_kitapisim.Text,txt_kitapyazar.Text,txt_dil.Text,txt_yayinevi.Text,txt_tur.Text,txt_adet.Text,txt_sayfa.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            // txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullaniciadi,sifre,yetki);
           
            string kitapid = txt_kitapid.Text;
            string kitapisim = txt_kitapisim.Text;
            string kitapyazar = txt_kitapyazar.Text;
            string dil = txt_dil.Text;
            string yayinevi = txt_yayinevi.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfa = txt_sayfa.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid,kitapisim,kitapyazar,dil,yayinevi,tur,adet,sayfa);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_uyeislemleri.Controls.Count; i++)
            {
                if (groupBox_uyeislemleri.Controls[i] is TextBox || groupBox_uyeislemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeislemleri.Controls[i].Text = string.Empty;
                }
            }
            for (int i = 0; i < groupBox_kitapislemleri.Controls.Count; i++)
            {
                if (groupBox_kitapislemleri.Controls[i] is TextBox)
                {
                    groupBox_kitapislemleri.Controls[i].Text = string.Empty;
                }
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); 
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text= dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text= dataGridView2.CurrentRow.Cells[7].Value.ToString();
            //txt_basimyili.Text= dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
