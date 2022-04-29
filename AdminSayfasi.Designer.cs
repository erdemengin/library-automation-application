
namespace KütüphaneOtomasyon2
{
    partial class AdminSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturmatarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_yetki = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_uyeislemleri = new System.Windows.Forms.GroupBox();
            this.groupBox_kitapislemleri = new System.Windows.Forms.GroupBox();
            this.btn_kitaptemizle = new System.Windows.Forms.Button();
            this.btn_kitapguncelle = new System.Windows.Forms.Button();
            this.btn_kitapsil = new System.Windows.Forms.Button();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.txt_dil = new System.Windows.Forms.TextBox();
            this.lbl_kitapdil = new System.Windows.Forms.Label();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_kitapyazar = new System.Windows.Forms.TextBox();
            this.lbl_kitapyazar = new System.Windows.Forms.Label();
            this.txt_kitapisim = new System.Windows.Forms.TextBox();
            this.lbl_kitapisim = new System.Windows.Forms.Label();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.lbl_kitapid = new System.Windows.Forms.Label();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_uyeislemleri.SuspendLayout();
            this.groupBox_kitapislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(320, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÜYELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim,
            this.olusturmatarih,
            this.kullaniciadi,
            this.sifre,
            this.yetki});
            this.dataGridView1.Location = new System.Drawing.Point(65, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 124);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "İD";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            this.isim.Width = 125;
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "SOYİSİM";
            this.soyisim.MinimumWidth = 6;
            this.soyisim.Name = "soyisim";
            this.soyisim.Width = 125;
            // 
            // olusturmatarih
            // 
            this.olusturmatarih.HeaderText = "OLUŞTURMA TARİH";
            this.olusturmatarih.MinimumWidth = 6;
            this.olusturmatarih.Name = "olusturmatarih";
            this.olusturmatarih.Width = 125;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.HeaderText = "KULLANICI ADI";
            this.kullaniciadi.MinimumWidth = 6;
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Width = 125;
            // 
            // sifre
            // 
            this.sifre.HeaderText = "ŞİFRE";
            this.sifre.MinimumWidth = 6;
            this.sifre.Name = "sifre";
            this.sifre.Width = 125;
            // 
            // yetki
            // 
            this.yetki.HeaderText = "YETKİ";
            this.yetki.MinimumWidth = 6;
            this.yetki.Name = "yetki";
            this.yetki.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1013, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "KİTAPLAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfasayisi,
            this.basimyili});
            this.dataGridView2.Location = new System.Drawing.Point(732, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(667, 124);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(73, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(175, 22);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "isim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(73, 60);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(175, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "soyisim";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(73, 104);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(175, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "oluşturma tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "kullanıcı adı";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(400, 65);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(175, 22);
            this.txt_kullaniciadi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(400, 104);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(175, 22);
            this.txt_sifre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "yetki";
            // 
            // txt_yetki
            // 
            this.txt_yetki.Location = new System.Drawing.Point(73, 146);
            this.txt_yetki.Name = "txt_yetki";
            this.txt_yetki.Size = new System.Drawing.Size(175, 22);
            this.txt_yetki.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(27, 225);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(632, 33);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(27, 264);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(632, 33);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(29, 303);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(632, 33);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(27, 340);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(632, 33);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(400, 27);
            this.maskedTextBox1.Mask = "00/00/0000 90:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(175, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox_uyeislemleri
            // 
            this.groupBox_uyeislemleri.Controls.Add(this.maskedTextBox1);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_temizle);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_guncelle);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_sil);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_ekle);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_yetki);
            this.groupBox_uyeislemleri.Controls.Add(this.label7);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_sifre);
            this.groupBox_uyeislemleri.Controls.Add(this.label6);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_kullaniciadi);
            this.groupBox_uyeislemleri.Controls.Add(this.label5);
            this.groupBox_uyeislemleri.Controls.Add(this.label4);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_soyisim);
            this.groupBox_uyeislemleri.Controls.Add(this.label3);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_isim);
            this.groupBox_uyeislemleri.Controls.Add(this.label2);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_id);
            this.groupBox_uyeislemleri.Controls.Add(this.label1);
            this.groupBox_uyeislemleri.Location = new System.Drawing.Point(25, 215);
            this.groupBox_uyeislemleri.Name = "groupBox_uyeislemleri";
            this.groupBox_uyeislemleri.Size = new System.Drawing.Size(667, 379);
            this.groupBox_uyeislemleri.TabIndex = 0;
            this.groupBox_uyeislemleri.TabStop = false;
            this.groupBox_uyeislemleri.Text = "Üye İşlemleri";
            this.groupBox_uyeislemleri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_kitapislemleri
            // 
            this.groupBox_kitapislemleri.Controls.Add(this.btn_kitaptemizle);
            this.groupBox_kitapislemleri.Controls.Add(this.btn_kitapguncelle);
            this.groupBox_kitapislemleri.Controls.Add(this.btn_kitapsil);
            this.groupBox_kitapislemleri.Controls.Add(this.btn_kitapekle);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_dil);
            this.groupBox_kitapislemleri.Controls.Add(this.lbl_kitapdil);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_sayfa);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_adet);
            this.groupBox_kitapislemleri.Controls.Add(this.label14);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_tur);
            this.groupBox_kitapislemleri.Controls.Add(this.label11);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_yayinevi);
            this.groupBox_kitapislemleri.Controls.Add(this.label10);
            this.groupBox_kitapislemleri.Controls.Add(this.label12);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_kitapyazar);
            this.groupBox_kitapislemleri.Controls.Add(this.lbl_kitapyazar);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_kitapisim);
            this.groupBox_kitapislemleri.Controls.Add(this.lbl_kitapisim);
            this.groupBox_kitapislemleri.Controls.Add(this.txt_kitapid);
            this.groupBox_kitapislemleri.Controls.Add(this.lbl_kitapid);
            this.groupBox_kitapislemleri.Location = new System.Drawing.Point(732, 229);
            this.groupBox_kitapislemleri.Name = "groupBox_kitapislemleri";
            this.groupBox_kitapislemleri.Size = new System.Drawing.Size(667, 379);
            this.groupBox_kitapislemleri.TabIndex = 0;
            this.groupBox_kitapislemleri.TabStop = false;
            this.groupBox_kitapislemleri.Text = "Kitap İşlemleri";
            this.groupBox_kitapislemleri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_kitaptemizle
            // 
            this.btn_kitaptemizle.Location = new System.Drawing.Point(19, 328);
            this.btn_kitaptemizle.Name = "btn_kitaptemizle";
            this.btn_kitaptemizle.Size = new System.Drawing.Size(632, 33);
            this.btn_kitaptemizle.TabIndex = 2;
            this.btn_kitaptemizle.Text = "temizle";
            this.btn_kitaptemizle.UseVisualStyleBackColor = true;
            this.btn_kitaptemizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kitapguncelle
            // 
            this.btn_kitapguncelle.Location = new System.Drawing.Point(19, 289);
            this.btn_kitapguncelle.Name = "btn_kitapguncelle";
            this.btn_kitapguncelle.Size = new System.Drawing.Size(632, 33);
            this.btn_kitapguncelle.TabIndex = 2;
            this.btn_kitapguncelle.Text = "güncelle";
            this.btn_kitapguncelle.UseVisualStyleBackColor = true;
            this.btn_kitapguncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kitapsil
            // 
            this.btn_kitapsil.Location = new System.Drawing.Point(19, 250);
            this.btn_kitapsil.Name = "btn_kitapsil";
            this.btn_kitapsil.Size = new System.Drawing.Size(632, 33);
            this.btn_kitapsil.TabIndex = 2;
            this.btn_kitapsil.Text = "sil";
            this.btn_kitapsil.UseVisualStyleBackColor = true;
            this.btn_kitapsil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Location = new System.Drawing.Point(21, 211);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(632, 33);
            this.btn_kitapekle.TabIndex = 2;
            this.btn_kitapekle.Text = "ekle";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_dil
            // 
            this.txt_dil.Location = new System.Drawing.Point(96, 132);
            this.txt_dil.Name = "txt_dil";
            this.txt_dil.Size = new System.Drawing.Size(175, 22);
            this.txt_dil.TabIndex = 1;
            // 
            // lbl_kitapdil
            // 
            this.lbl_kitapdil.AutoSize = true;
            this.lbl_kitapdil.Location = new System.Drawing.Point(51, 134);
            this.lbl_kitapdil.Name = "lbl_kitapdil";
            this.lbl_kitapdil.Size = new System.Drawing.Size(22, 17);
            this.lbl_kitapdil.TabIndex = 0;
            this.lbl_kitapdil.Text = "dil";
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(421, 134);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(175, 22);
            this.txt_sayfa.TabIndex = 1;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(421, 92);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(175, 22);
            this.txt_adet.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "sayfa";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(421, 58);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(175, 22);
            this.txt_tur.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "adet";
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Location = new System.Drawing.Point(421, 25);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(175, 22);
            this.txt_yayinevi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "yayınevi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "tür";
            // 
            // txt_kitapyazar
            // 
            this.txt_kitapyazar.Location = new System.Drawing.Point(96, 95);
            this.txt_kitapyazar.Name = "txt_kitapyazar";
            this.txt_kitapyazar.Size = new System.Drawing.Size(175, 22);
            this.txt_kitapyazar.TabIndex = 1;
            // 
            // lbl_kitapyazar
            // 
            this.lbl_kitapyazar.AutoSize = true;
            this.lbl_kitapyazar.Location = new System.Drawing.Point(7, 95);
            this.lbl_kitapyazar.Name = "lbl_kitapyazar";
            this.lbl_kitapyazar.Size = new System.Drawing.Size(77, 17);
            this.lbl_kitapyazar.TabIndex = 0;
            this.lbl_kitapyazar.Text = "kitap yazar";
            // 
            // txt_kitapisim
            // 
            this.txt_kitapisim.Location = new System.Drawing.Point(96, 62);
            this.txt_kitapisim.Name = "txt_kitapisim";
            this.txt_kitapisim.Size = new System.Drawing.Size(175, 22);
            this.txt_kitapisim.TabIndex = 1;
            // 
            // lbl_kitapisim
            // 
            this.lbl_kitapisim.AutoSize = true;
            this.lbl_kitapisim.Location = new System.Drawing.Point(18, 56);
            this.lbl_kitapisim.Name = "lbl_kitapisim";
            this.lbl_kitapisim.Size = new System.Drawing.Size(66, 17);
            this.lbl_kitapisim.TabIndex = 0;
            this.lbl_kitapisim.Text = "kitap isim";
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(96, 25);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(175, 22);
            this.txt_kitapid.TabIndex = 1;
            // 
            // lbl_kitapid
            // 
            this.lbl_kitapid.AutoSize = true;
            this.lbl_kitapid.Location = new System.Drawing.Point(54, 28);
            this.lbl_kitapid.Name = "lbl_kitapid";
            this.lbl_kitapid.Size = new System.Drawing.Size(19, 17);
            this.lbl_kitapid.TabIndex = 0;
            this.lbl_kitapid.Text = "id";
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAP İD";
            this.kitapid.MinimumWidth = 6;
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 75;
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.MinimumWidth = 6;
            this.kitapisim.Name = "kitapisim";
            this.kitapisim.Width = 75;
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "KİTAP YAZAR";
            this.kitapyazar.MinimumWidth = 6;
            this.kitapyazar.Name = "kitapyazar";
            this.kitapyazar.Width = 75;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.MinimumWidth = 6;
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 75;
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYINEVİ";
            this.yayinevi.MinimumWidth = 6;
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 75;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.MinimumWidth = 6;
            this.tur.Name = "tur";
            this.tur.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.HeaderText = "SAYFA SAYISI";
            this.sayfasayisi.MinimumWidth = 6;
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Width = 75;
            // 
            // basimyili
            // 
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.MinimumWidth = 6;
            this.basimyili.Name = "basimyili";
            this.basimyili.Width = 75;
            // 
            // AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 602);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox_kitapislemleri);
            this.Controls.Add(this.groupBox_uyeislemleri);
            this.Name = "AdminSayfasi";
            this.Text = "AdminSayfasi";
            this.Load += new System.EventHandler(this.AdminSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_uyeislemleri.ResumeLayout(false);
            this.groupBox_uyeislemleri.PerformLayout();
            this.groupBox_kitapislemleri.ResumeLayout(false);
            this.groupBox_kitapislemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturmatarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetki;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_yetki;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox_uyeislemleri;
        private System.Windows.Forms.GroupBox groupBox_kitapislemleri;
        private System.Windows.Forms.Button btn_kitaptemizle;
        private System.Windows.Forms.Button btn_kitapguncelle;
        private System.Windows.Forms.Button btn_kitapsil;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.TextBox txt_dil;
        private System.Windows.Forms.Label lbl_kitapdil;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_yayinevi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_kitapyazar;
        private System.Windows.Forms.Label lbl_kitapyazar;
        private System.Windows.Forms.TextBox txt_kitapisim;
        private System.Windows.Forms.Label lbl_kitapisim;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label lbl_kitapid;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}