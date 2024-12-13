namespace BiletSatis.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btn_Güncelle = new Button();
            btn_Ekle = new Button();
            nud_Kapasite = new NumericUpDown();
            txt_SalonAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgw_Salon = new DataGridView();
            cms_Salon = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            dtp_EtkinlikBitiş = new DateTimePicker();
            dtp_EtkinlikBaşlangıç = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            cmb_Salonlar = new ComboBox();
            label6 = new Label();
            btn_EtkinlikGüncelle = new Button();
            btn_EtkinlikEkle = new Button();
            dgw_Etkinlik = new DataGridView();
            cms_Etkinlik = new ContextMenuStrip(components);
            silEtkinlikToolStripMenuItem1 = new ToolStripMenuItem();
            güncelleEtkinlikToolStripMenuItem1 = new ToolStripMenuItem();
            nud_yasSiniri = new NumericUpDown();
            nud_biletUcreti = new NumericUpDown();
            txt_EtkinlikAdi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Bilet = new GroupBox();
            label14 = new Label();
            cmb_biletEtkinlik = new ComboBox();
            btn_biletGüncelle = new Button();
            btn_biletEkle = new Button();
            dgw_bilet = new DataGridView();
            cms_bilet = new ContextMenuStrip(components);
            sİLBiletToolStripMenuItem = new ToolStripMenuItem();
            gÜNCELLEBiletToolStripMenuItem1 = new ToolStripMenuItem();
            chk_indirim = new CheckBox();
            dtp_dogumTarihi = new DateTimePicker();
            chk_erkek = new CheckBox();
            chk_Kadın = new CheckBox();
            txt_telefon = new TextBox();
            txt_BiletAdSoyad = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Kapasite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Salon).BeginInit();
            cms_Salon.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Etkinlik).BeginInit();
            cms_Etkinlik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_yasSiniri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_biletUcreti).BeginInit();
            Bilet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_bilet).BeginInit();
            cms_bilet.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Güncelle);
            groupBox1.Controls.Add(btn_Ekle);
            groupBox1.Controls.Add(nud_Kapasite);
            groupBox1.Controls.Add(txt_SalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgw_Salon);
            groupBox1.Location = new Point(65, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Salon";
            // 
            // btn_Güncelle
            // 
            btn_Güncelle.BackColor = Color.Lime;
            btn_Güncelle.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Güncelle.Location = new Point(248, 124);
            btn_Güncelle.Name = "btn_Güncelle";
            btn_Güncelle.Size = new Size(139, 42);
            btn_Güncelle.TabIndex = 6;
            btn_Güncelle.Text = "GÜNCELLE";
            btn_Güncelle.UseVisualStyleBackColor = false;
            btn_Güncelle.Click += btn_Güncelle_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackColor = Color.Yellow;
            btn_Ekle.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Ekle.Location = new Point(54, 119);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(113, 47);
            btn_Ekle.TabIndex = 5;
            btn_Ekle.Text = "EKLE";
            btn_Ekle.UseVisualStyleBackColor = false;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // nud_Kapasite
            // 
            nud_Kapasite.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nud_Kapasite.Location = new Point(142, 86);
            nud_Kapasite.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Kapasite.Name = "nud_Kapasite";
            nud_Kapasite.Size = new Size(184, 27);
            nud_Kapasite.TabIndex = 4;
            nud_Kapasite.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // txt_SalonAdi
            // 
            txt_SalonAdi.Location = new Point(143, 32);
            txt_SalonAdi.Name = "txt_SalonAdi";
            txt_SalonAdi.Size = new Size(183, 27);
            txt_SalonAdi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Kapasite:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Salon Adı:";
            // 
            // dgw_Salon
            // 
            dgw_Salon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Salon.ContextMenuStrip = cms_Salon;
            dgw_Salon.Location = new Point(35, 171);
            dgw_Salon.MultiSelect = false;
            dgw_Salon.Name = "dgw_Salon";
            dgw_Salon.ReadOnly = true;
            dgw_Salon.RowHeadersWidth = 51;
            dgw_Salon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Salon.Size = new Size(370, 153);
            dgw_Salon.TabIndex = 0;
            // 
            // cms_Salon
            // 
            cms_Salon.ImageScalingSize = new Size(20, 20);
            cms_Salon.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
            cms_Salon.Name = "cms_Salon";
            cms_Salon.Size = new Size(136, 52);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(135, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(135, 24);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtp_EtkinlikBitiş);
            groupBox2.Controls.Add(dtp_EtkinlikBaşlangıç);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmb_Salonlar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btn_EtkinlikGüncelle);
            groupBox2.Controls.Add(btn_EtkinlikEkle);
            groupBox2.Controls.Add(dgw_Etkinlik);
            groupBox2.Controls.Add(nud_yasSiniri);
            groupBox2.Controls.Add(nud_biletUcreti);
            groupBox2.Controls.Add(txt_EtkinlikAdi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(723, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 436);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etkinlik";
            // 
            // dtp_EtkinlikBitiş
            // 
            dtp_EtkinlikBitiş.CustomFormat = "dd/MM/yyyy HH:mm";
            dtp_EtkinlikBitiş.Format = DateTimePickerFormat.Custom;
            dtp_EtkinlikBitiş.Location = new Point(523, 122);
            dtp_EtkinlikBitiş.Name = "dtp_EtkinlikBitiş";
            dtp_EtkinlikBitiş.Size = new Size(227, 27);
            dtp_EtkinlikBitiş.TabIndex = 14;
            // 
            // dtp_EtkinlikBaşlangıç
            // 
            dtp_EtkinlikBaşlangıç.CustomFormat = "dd/MM/yyyy HH:mm";
            dtp_EtkinlikBaşlangıç.Format = DateTimePickerFormat.Custom;
            dtp_EtkinlikBaşlangıç.Location = new Point(523, 86);
            dtp_EtkinlikBaşlangıç.Name = "dtp_EtkinlikBaşlangıç";
            dtp_EtkinlikBaşlangıç.Size = new Size(227, 27);
            dtp_EtkinlikBaşlangıç.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 127);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 12;
            label8.Text = "Bitiş Zamanı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 86);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 11;
            label7.Text = "Başlangıç Zamanı:";
            // 
            // cmb_Salonlar
            // 
            cmb_Salonlar.FormattingEnabled = true;
            cmb_Salonlar.Location = new Point(523, 37);
            cmb_Salonlar.Name = "cmb_Salonlar";
            cmb_Salonlar.Size = new Size(227, 28);
            cmb_Salonlar.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 40);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 9;
            label6.Text = "Etkinlik Salonu";
            // 
            // btn_EtkinlikGüncelle
            // 
            btn_EtkinlikGüncelle.BackColor = Color.FromArgb(255, 128, 0);
            btn_EtkinlikGüncelle.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_EtkinlikGüncelle.Location = new Point(523, 160);
            btn_EtkinlikGüncelle.Name = "btn_EtkinlikGüncelle";
            btn_EtkinlikGüncelle.Size = new Size(139, 42);
            btn_EtkinlikGüncelle.TabIndex = 8;
            btn_EtkinlikGüncelle.Text = "GÜNCELLE";
            btn_EtkinlikGüncelle.UseVisualStyleBackColor = false;
            btn_EtkinlikGüncelle.Click += btn_EtkinlikGüncelle_Click;
            // 
            // btn_EtkinlikEkle
            // 
            btn_EtkinlikEkle.BackColor = Color.FromArgb(192, 0, 192);
            btn_EtkinlikEkle.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_EtkinlikEkle.Location = new Point(121, 155);
            btn_EtkinlikEkle.Name = "btn_EtkinlikEkle";
            btn_EtkinlikEkle.Size = new Size(129, 47);
            btn_EtkinlikEkle.TabIndex = 7;
            btn_EtkinlikEkle.Text = "EKLE";
            btn_EtkinlikEkle.UseVisualStyleBackColor = false;
            btn_EtkinlikEkle.Click += btn_EtkinlikEkle_Click;
            // 
            // dgw_Etkinlik
            // 
            dgw_Etkinlik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Etkinlik.ContextMenuStrip = cms_Etkinlik;
            dgw_Etkinlik.Location = new Point(40, 208);
            dgw_Etkinlik.MultiSelect = false;
            dgw_Etkinlik.Name = "dgw_Etkinlik";
            dgw_Etkinlik.ReadOnly = true;
            dgw_Etkinlik.RowHeadersWidth = 51;
            dgw_Etkinlik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Etkinlik.Size = new Size(742, 172);
            dgw_Etkinlik.TabIndex = 6;
            // 
            // cms_Etkinlik
            // 
            cms_Etkinlik.ImageScalingSize = new Size(20, 20);
            cms_Etkinlik.Items.AddRange(new ToolStripItem[] { silEtkinlikToolStripMenuItem1, güncelleEtkinlikToolStripMenuItem1 });
            cms_Etkinlik.Name = "cms_Etkinlik";
            cms_Etkinlik.Size = new Size(136, 52);
            // 
            // silEtkinlikToolStripMenuItem1
            // 
            silEtkinlikToolStripMenuItem1.Name = "silEtkinlikToolStripMenuItem1";
            silEtkinlikToolStripMenuItem1.Size = new Size(135, 24);
            silEtkinlikToolStripMenuItem1.Text = "Sil";
            silEtkinlikToolStripMenuItem1.Click += silEtkinlikToolStripMenuItem1_Click;
            // 
            // güncelleEtkinlikToolStripMenuItem1
            // 
            güncelleEtkinlikToolStripMenuItem1.Name = "güncelleEtkinlikToolStripMenuItem1";
            güncelleEtkinlikToolStripMenuItem1.Size = new Size(135, 24);
            güncelleEtkinlikToolStripMenuItem1.Text = "Güncelle";
            güncelleEtkinlikToolStripMenuItem1.Click += güncelleEtkinlikToolStripMenuItem1_Click;
            // 
            // nud_yasSiniri
            // 
            nud_yasSiniri.Cursor = Cursors.No;
            nud_yasSiniri.Location = new Point(130, 120);
            nud_yasSiniri.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nud_yasSiniri.Name = "nud_yasSiniri";
            nud_yasSiniri.Size = new Size(172, 27);
            nud_yasSiniri.TabIndex = 5;
            nud_yasSiniri.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // nud_biletUcreti
            // 
            nud_biletUcreti.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nud_biletUcreti.Location = new Point(131, 75);
            nud_biletUcreti.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_biletUcreti.Name = "nud_biletUcreti";
            nud_biletUcreti.Size = new Size(171, 27);
            nud_biletUcreti.TabIndex = 4;
            // 
            // txt_EtkinlikAdi
            // 
            txt_EtkinlikAdi.Location = new Point(131, 34);
            txt_EtkinlikAdi.Name = "txt_EtkinlikAdi";
            txt_EtkinlikAdi.Size = new Size(171, 27);
            txt_EtkinlikAdi.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 121);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Yaş Sınırı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 77);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 1;
            label4.Text = "Bilet Ücreti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 37);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Etkinlik Adı:";
            // 
            // Bilet
            // 
            Bilet.Controls.Add(label14);
            Bilet.Controls.Add(cmb_biletEtkinlik);
            Bilet.Controls.Add(btn_biletGüncelle);
            Bilet.Controls.Add(btn_biletEkle);
            Bilet.Controls.Add(dgw_bilet);
            Bilet.Controls.Add(chk_indirim);
            Bilet.Controls.Add(dtp_dogumTarihi);
            Bilet.Controls.Add(chk_erkek);
            Bilet.Controls.Add(chk_Kadın);
            Bilet.Controls.Add(txt_telefon);
            Bilet.Controls.Add(txt_BiletAdSoyad);
            Bilet.Controls.Add(label13);
            Bilet.Controls.Add(label12);
            Bilet.Controls.Add(label11);
            Bilet.Controls.Add(label10);
            Bilet.Controls.Add(label9);
            Bilet.Location = new Point(40, 484);
            Bilet.Name = "Bilet";
            Bilet.Size = new Size(1570, 367);
            Bilet.TabIndex = 2;
            Bilet.TabStop = false;
            Bilet.Text = "Bilet";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 258);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 15;
            label14.Text = "Etkinlik :";
            // 
            // cmb_biletEtkinlik
            // 
            cmb_biletEtkinlik.FormattingEnabled = true;
            cmb_biletEtkinlik.Location = new Point(132, 250);
            cmb_biletEtkinlik.Name = "cmb_biletEtkinlik";
            cmb_biletEtkinlik.Size = new Size(190, 28);
            cmb_biletEtkinlik.TabIndex = 14;
            // 
            // btn_biletGüncelle
            // 
            btn_biletGüncelle.Location = new Point(248, 303);
            btn_biletGüncelle.Name = "btn_biletGüncelle";
            btn_biletGüncelle.Size = new Size(134, 33);
            btn_biletGüncelle.TabIndex = 13;
            btn_biletGüncelle.Text = "GÜNCELLE";
            btn_biletGüncelle.UseVisualStyleBackColor = true;
            btn_biletGüncelle.Click += btn_biletGüncelle_Click;
            // 
            // btn_biletEkle
            // 
            btn_biletEkle.Location = new Point(47, 303);
            btn_biletEkle.Name = "btn_biletEkle";
            btn_biletEkle.Size = new Size(134, 33);
            btn_biletEkle.TabIndex = 12;
            btn_biletEkle.Text = "EKLE";
            btn_biletEkle.UseVisualStyleBackColor = true;
            btn_biletEkle.Click += btn_biletEkle_Click;
            // 
            // dgw_bilet
            // 
            dgw_bilet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_bilet.ContextMenuStrip = cms_bilet;
            dgw_bilet.Location = new Point(467, 26);
            dgw_bilet.MultiSelect = false;
            dgw_bilet.Name = "dgw_bilet";
            dgw_bilet.ReadOnly = true;
            dgw_bilet.RowHeadersWidth = 51;
            dgw_bilet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_bilet.Size = new Size(1037, 252);
            dgw_bilet.TabIndex = 11;
            // 
            // cms_bilet
            // 
            cms_bilet.ImageScalingSize = new Size(20, 20);
            cms_bilet.Items.AddRange(new ToolStripItem[] { sİLBiletToolStripMenuItem, gÜNCELLEBiletToolStripMenuItem1 });
            cms_bilet.Name = "cms_bilet";
            cms_bilet.Size = new Size(149, 52);
            // 
            // sİLBiletToolStripMenuItem
            // 
            sİLBiletToolStripMenuItem.Name = "sİLBiletToolStripMenuItem";
            sİLBiletToolStripMenuItem.Size = new Size(148, 24);
            sİLBiletToolStripMenuItem.Text = "SİL";
            sİLBiletToolStripMenuItem.Click += sİLBiletToolStripMenuItem_Click;
            // 
            // gÜNCELLEBiletToolStripMenuItem1
            // 
            gÜNCELLEBiletToolStripMenuItem1.Name = "gÜNCELLEBiletToolStripMenuItem1";
            gÜNCELLEBiletToolStripMenuItem1.Size = new Size(148, 24);
            gÜNCELLEBiletToolStripMenuItem1.Text = "GÜNCELLE";
            gÜNCELLEBiletToolStripMenuItem1.Click += gÜNCELLEBiletToolStripMenuItem1_Click;
            // 
            // chk_indirim
            // 
            chk_indirim.AutoSize = true;
            chk_indirim.Location = new Point(132, 212);
            chk_indirim.Name = "chk_indirim";
            chk_indirim.Size = new Size(59, 24);
            chk_indirim.TabIndex = 10;
            chk_indirim.Text = "Evet";
            chk_indirim.UseVisualStyleBackColor = true;
            // 
            // dtp_dogumTarihi
            // 
            dtp_dogumTarihi.Location = new Point(136, 171);
            dtp_dogumTarihi.Name = "dtp_dogumTarihi";
            dtp_dogumTarihi.Size = new Size(224, 27);
            dtp_dogumTarihi.TabIndex = 9;
            // 
            // chk_erkek
            // 
            chk_erkek.AutoSize = true;
            chk_erkek.Location = new Point(228, 132);
            chk_erkek.Name = "chk_erkek";
            chk_erkek.Size = new Size(66, 24);
            chk_erkek.TabIndex = 8;
            chk_erkek.Text = "Erkek";
            chk_erkek.UseVisualStyleBackColor = true;
            // 
            // chk_Kadın
            // 
            chk_Kadın.AutoSize = true;
            chk_Kadın.Location = new Point(121, 132);
            chk_Kadın.Name = "chk_Kadın";
            chk_Kadın.Size = new Size(69, 24);
            chk_Kadın.TabIndex = 7;
            chk_Kadın.Text = "Kadın";
            chk_Kadın.UseVisualStyleBackColor = true;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(113, 84);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(247, 27);
            txt_telefon.TabIndex = 6;
            // 
            // txt_BiletAdSoyad
            // 
            txt_BiletAdSoyad.Location = new Point(113, 30);
            txt_BiletAdSoyad.Name = "txt_BiletAdSoyad";
            txt_BiletAdSoyad.Size = new Size(247, 27);
            txt_BiletAdSoyad.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 213);
            label13.Name = "label13";
            label13.Size = new Size(63, 20);
            label13.TabIndex = 4;
            label13.Text = "İndirim :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 171);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 3;
            label12.Text = "Doğum Tarihi :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 132);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 2;
            label11.Text = "Cinsiyet :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 87);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 1;
            label10.Text = "Telefon :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 36);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 0;
            label9.Text = "Adı Soyadı :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1854, 895);
            Controls.Add(Bilet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Kapasite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Salon).EndInit();
            cms_Salon.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Etkinlik).EndInit();
            cms_Etkinlik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_yasSiniri).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_biletUcreti).EndInit();
            Bilet.ResumeLayout(false);
            Bilet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_bilet).EndInit();
            cms_bilet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Güncelle;
        private Button btn_Ekle;
        private NumericUpDown nud_Kapasite;
        private TextBox txt_SalonAdi;
        private Label label2;
        private Label label1;
        private DataGridView dgw_Salon;
        private ContextMenuStrip cms_Salon;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown nud_yasSiniri;
        private NumericUpDown nud_biletUcreti;
        private TextBox txt_EtkinlikAdi;
        private Button btn_EtkinlikGüncelle;
        private Button btn_EtkinlikEkle;
        private DataGridView dgw_Etkinlik;
        private ContextMenuStrip cms_Etkinlik;
        private ToolStripMenuItem silEtkinlikToolStripMenuItem1;
        private ToolStripMenuItem güncelleEtkinlikToolStripMenuItem1;
        private ComboBox cmb_Salonlar;
        private Label label6;
        private Label label7;
        private DateTimePicker dtp_EtkinlikBitiş;
        private DateTimePicker dtp_EtkinlikBaşlangıç;
        private Label label8;
        private GroupBox Bilet;
        private CheckBox chk_indirim;
        private DateTimePicker dtp_dogumTarihi;
        private CheckBox chk_erkek;
        private CheckBox chk_Kadın;
        private TextBox txt_telefon;
        private TextBox txt_BiletAdSoyad;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btn_biletGüncelle;
        private Button btn_biletEkle;
        private DataGridView dgw_bilet;
        private ContextMenuStrip cms_bilet;
        private ToolStripMenuItem sİLBiletToolStripMenuItem;
        private ToolStripMenuItem gÜNCELLEBiletToolStripMenuItem1;
        private Label label14;
        private ComboBox cmb_biletEtkinlik;
    }
}
