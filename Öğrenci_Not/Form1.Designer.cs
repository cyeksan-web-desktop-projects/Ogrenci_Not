
namespace Öğrenci_Not
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
            this.cmbKulup = new System.Windows.Forms.ComboBox();
            this.grpOgrBilgileri = new System.Windows.Forms.GroupBox();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtFotograf = new System.Windows.Forms.TextBox();
            this.lblKulup = new System.Windows.Forms.Label();
            this.lblFotograf = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grpNotlar = new System.Windows.Forms.GroupBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.lblOrt = new System.Windows.Forms.Label();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.lblProje = new System.Windows.Forms.Label();
            this.btnNotListele = new System.Windows.Forms.Button();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.lblOgrId = new System.Windows.Forms.Label();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.lblSinav3 = new System.Windows.Forms.Label();
            this.lblSinav2 = new System.Windows.Forms.Label();
            this.lblSinav1 = new System.Windows.Forms.Label();
            this.grpKulup = new System.Windows.Forms.GroupBox();
            this.btnKulupListele = new System.Windows.Forms.Button();
            this.btnKulupGuncelle = new System.Windows.Forms.Button();
            this.btnKulupSil = new System.Windows.Forms.Button();
            this.btnKulupKaydet = new System.Windows.Forms.Button();
            this.lblKulupId = new System.Windows.Forms.Label();
            this.txtKulupId = new System.Windows.Forms.TextBox();
            this.txtKulupAd = new System.Windows.Forms.TextBox();
            this.lblKulupAd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpOgrBilgileri.SuspendLayout();
            this.grpNotlar.SuspendLayout();
            this.grpKulup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKulup
            // 
            this.cmbKulup.AllowDrop = true;
            this.cmbKulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKulup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKulup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbKulup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbKulup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKulup.Location = new System.Drawing.Point(103, 167);
            this.cmbKulup.Name = "cmbKulup";
            this.cmbKulup.Size = new System.Drawing.Size(174, 23);
            this.cmbKulup.TabIndex = 5;
            this.cmbKulup.Tag = "";
            // 
            // grpOgrBilgileri
            // 
            this.grpOgrBilgileri.Controls.Add(this.btnOgrenciListele);
            this.grpOgrBilgileri.Controls.Add(this.btnOgrenciGuncelle);
            this.grpOgrBilgileri.Controls.Add(this.btnOgrenciSil);
            this.grpOgrBilgileri.Controls.Add(this.btnOgrenciKaydet);
            this.grpOgrBilgileri.Controls.Add(this.lblId);
            this.grpOgrBilgileri.Controls.Add(this.txtId);
            this.grpOgrBilgileri.Controls.Add(this.txtAd);
            this.grpOgrBilgileri.Controls.Add(this.txtSoyad);
            this.grpOgrBilgileri.Controls.Add(this.txtFotograf);
            this.grpOgrBilgileri.Controls.Add(this.cmbKulup);
            this.grpOgrBilgileri.Controls.Add(this.lblKulup);
            this.grpOgrBilgileri.Controls.Add(this.lblFotograf);
            this.grpOgrBilgileri.Controls.Add(this.lblSoyad);
            this.grpOgrBilgileri.Controls.Add(this.lblAd);
            this.grpOgrBilgileri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpOgrBilgileri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpOgrBilgileri.Location = new System.Drawing.Point(29, 12);
            this.grpOgrBilgileri.Name = "grpOgrBilgileri";
            this.grpOgrBilgileri.Size = new System.Drawing.Size(333, 274);
            this.grpOgrBilgileri.TabIndex = 0;
            this.grpOgrBilgileri.TabStop = false;
            this.grpOgrBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOgrenciListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciListele.Location = new System.Drawing.Point(195, 229);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(82, 25);
            this.btnOgrenciListele.TabIndex = 13;
            this.btnOgrenciListele.Text = "Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = false;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOgrenciGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(103, 229);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(86, 25);
            this.btnOgrenciGuncelle.TabIndex = 12;
            this.btnOgrenciGuncelle.Text = "Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = false;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.BackColor = System.Drawing.Color.Tomato;
            this.btnOgrenciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciSil.Location = new System.Drawing.Point(103, 198);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(86, 25);
            this.btnOgrenciSil.TabIndex = 11;
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = false;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOgrenciKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(195, 198);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(82, 25);
            this.btnOgrenciKaydet.TabIndex = 10;
            this.btnOgrenciKaydet.Text = "Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = false;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(6, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtId.Location = new System.Drawing.Point(103, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 23);
            this.txtId.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAd.Location = new System.Drawing.Point(103, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 23);
            this.txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSoyad.Location = new System.Drawing.Point(103, 106);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(174, 23);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtFotograf
            // 
            this.txtFotograf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFotograf.Location = new System.Drawing.Point(103, 137);
            this.txtFotograf.Name = "txtFotograf";
            this.txtFotograf.Size = new System.Drawing.Size(174, 23);
            this.txtFotograf.TabIndex = 6;
            // 
            // lblKulup
            // 
            this.lblKulup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKulup.Location = new System.Drawing.Point(6, 170);
            this.lblKulup.Name = "lblKulup";
            this.lblKulup.Size = new System.Drawing.Size(87, 20);
            this.lblKulup.TabIndex = 4;
            this.lblKulup.Text = "KULÜP:";
            this.lblKulup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFotograf
            // 
            this.lblFotograf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFotograf.Location = new System.Drawing.Point(6, 140);
            this.lblFotograf.Name = "lblFotograf";
            this.lblFotograf.Size = new System.Drawing.Size(86, 20);
            this.lblFotograf.TabIndex = 3;
            this.lblFotograf.Text = "FOTOĞRAF:";
            this.lblFotograf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyad.Location = new System.Drawing.Point(6, 109);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(86, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "SOYAD:";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.Location = new System.Drawing.Point(6, 78);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(87, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "AD:";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpNotlar
            // 
            this.grpNotlar.Controls.Add(this.txtDurum);
            this.grpNotlar.Controls.Add(this.lblDurum);
            this.grpNotlar.Controls.Add(this.txtOrt);
            this.grpNotlar.Controls.Add(this.lblOrt);
            this.grpNotlar.Controls.Add(this.txtProje);
            this.grpNotlar.Controls.Add(this.lblProje);
            this.grpNotlar.Controls.Add(this.btnNotListele);
            this.grpNotlar.Controls.Add(this.btnNotGuncelle);
            this.grpNotlar.Controls.Add(this.lblOgrId);
            this.grpNotlar.Controls.Add(this.txtOgrId);
            this.grpNotlar.Controls.Add(this.txtSinav1);
            this.grpNotlar.Controls.Add(this.txtSinav2);
            this.grpNotlar.Controls.Add(this.txtSinav3);
            this.grpNotlar.Controls.Add(this.lblSinav3);
            this.grpNotlar.Controls.Add(this.lblSinav2);
            this.grpNotlar.Controls.Add(this.lblSinav1);
            this.grpNotlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpNotlar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpNotlar.Location = new System.Drawing.Point(387, 12);
            this.grpNotlar.Name = "grpNotlar";
            this.grpNotlar.Size = new System.Drawing.Size(333, 274);
            this.grpNotlar.TabIndex = 14;
            this.grpNotlar.TabStop = false;
            this.grpNotlar.Text = "Notlar";
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDurum.Location = new System.Drawing.Point(232, 137);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(45, 23);
            this.txtDurum.TabIndex = 19;
            // 
            // lblDurum
            // 
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurum.Location = new System.Drawing.Point(155, 140);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(62, 20);
            this.lblDurum.TabIndex = 18;
            this.lblDurum.Text = "DURUM:";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOrt
            // 
            this.txtOrt.Enabled = false;
            this.txtOrt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrt.Location = new System.Drawing.Point(232, 106);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(45, 23);
            this.txtOrt.TabIndex = 17;
            // 
            // lblOrt
            // 
            this.lblOrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrt.Location = new System.Drawing.Point(167, 109);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(50, 20);
            this.lblOrt.TabIndex = 16;
            this.lblOrt.Text = "ORT.:";
            this.lblOrt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProje
            // 
            this.txtProje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProje.Location = new System.Drawing.Point(232, 75);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(45, 23);
            this.txtProje.TabIndex = 15;
            // 
            // lblProje
            // 
            this.lblProje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProje.Location = new System.Drawing.Point(167, 78);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(50, 20);
            this.lblProje.TabIndex = 14;
            this.lblProje.Text = "PROJE:";
            this.lblProje.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNotListele
            // 
            this.btnNotListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNotListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotListele.Location = new System.Drawing.Point(195, 229);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new System.Drawing.Size(82, 25);
            this.btnNotListele.TabIndex = 13;
            this.btnNotListele.Text = "Listele";
            this.btnNotListele.UseVisualStyleBackColor = false;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNotGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotGuncelle.Location = new System.Drawing.Point(103, 229);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(86, 25);
            this.btnNotGuncelle.TabIndex = 12;
            this.btnNotGuncelle.Text = "Güncelle";
            this.btnNotGuncelle.UseVisualStyleBackColor = false;
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // lblOgrId
            // 
            this.lblOgrId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOgrId.Location = new System.Drawing.Point(6, 47);
            this.lblOgrId.Name = "lblOgrId";
            this.lblOgrId.Size = new System.Drawing.Size(87, 23);
            this.lblOgrId.TabIndex = 0;
            this.lblOgrId.Text = "ÖĞRENCİ ID:";
            this.lblOgrId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOgrId
            // 
            this.txtOgrId.Enabled = false;
            this.txtOgrId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOgrId.Location = new System.Drawing.Point(103, 44);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(174, 23);
            this.txtOgrId.TabIndex = 9;
            // 
            // txtSinav1
            // 
            this.txtSinav1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSinav1.Location = new System.Drawing.Point(103, 75);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(46, 23);
            this.txtSinav1.TabIndex = 8;
            // 
            // txtSinav2
            // 
            this.txtSinav2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSinav2.Location = new System.Drawing.Point(103, 106);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(46, 23);
            this.txtSinav2.TabIndex = 7;
            // 
            // txtSinav3
            // 
            this.txtSinav3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSinav3.Location = new System.Drawing.Point(103, 137);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(46, 23);
            this.txtSinav3.TabIndex = 6;
            // 
            // lblSinav3
            // 
            this.lblSinav3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinav3.Location = new System.Drawing.Point(6, 140);
            this.lblSinav3.Name = "lblSinav3";
            this.lblSinav3.Size = new System.Drawing.Size(86, 20);
            this.lblSinav3.TabIndex = 3;
            this.lblSinav3.Text = "SINAV 3:";
            this.lblSinav3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSinav2
            // 
            this.lblSinav2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinav2.Location = new System.Drawing.Point(6, 109);
            this.lblSinav2.Name = "lblSinav2";
            this.lblSinav2.Size = new System.Drawing.Size(86, 20);
            this.lblSinav2.TabIndex = 2;
            this.lblSinav2.Text = "SINAV 2:";
            this.lblSinav2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSinav1
            // 
            this.lblSinav1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinav1.Location = new System.Drawing.Point(6, 78);
            this.lblSinav1.Name = "lblSinav1";
            this.lblSinav1.Size = new System.Drawing.Size(87, 20);
            this.lblSinav1.TabIndex = 1;
            this.lblSinav1.Text = "SINAV 1:";
            this.lblSinav1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpKulup
            // 
            this.grpKulup.Controls.Add(this.btnKulupListele);
            this.grpKulup.Controls.Add(this.btnKulupGuncelle);
            this.grpKulup.Controls.Add(this.btnKulupSil);
            this.grpKulup.Controls.Add(this.btnKulupKaydet);
            this.grpKulup.Controls.Add(this.lblKulupId);
            this.grpKulup.Controls.Add(this.txtKulupId);
            this.grpKulup.Controls.Add(this.txtKulupAd);
            this.grpKulup.Controls.Add(this.lblKulupAd);
            this.grpKulup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpKulup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpKulup.Location = new System.Drawing.Point(743, 12);
            this.grpKulup.Name = "grpKulup";
            this.grpKulup.Size = new System.Drawing.Size(333, 274);
            this.grpKulup.TabIndex = 14;
            this.grpKulup.TabStop = false;
            this.grpKulup.Text = "Kulüpler";
            // 
            // btnKulupListele
            // 
            this.btnKulupListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKulupListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulupListele.Location = new System.Drawing.Point(195, 229);
            this.btnKulupListele.Name = "btnKulupListele";
            this.btnKulupListele.Size = new System.Drawing.Size(82, 25);
            this.btnKulupListele.TabIndex = 13;
            this.btnKulupListele.Text = "Listele";
            this.btnKulupListele.UseVisualStyleBackColor = false;
            this.btnKulupListele.Click += new System.EventHandler(this.btnKulupListele_Click);
            // 
            // btnKulupGuncelle
            // 
            this.btnKulupGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKulupGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulupGuncelle.Location = new System.Drawing.Point(103, 229);
            this.btnKulupGuncelle.Name = "btnKulupGuncelle";
            this.btnKulupGuncelle.Size = new System.Drawing.Size(86, 25);
            this.btnKulupGuncelle.TabIndex = 12;
            this.btnKulupGuncelle.Text = "Güncelle";
            this.btnKulupGuncelle.UseVisualStyleBackColor = false;
            this.btnKulupGuncelle.Click += new System.EventHandler(this.btnKulupGuncelle_Click);
            // 
            // btnKulupSil
            // 
            this.btnKulupSil.BackColor = System.Drawing.Color.Tomato;
            this.btnKulupSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulupSil.Location = new System.Drawing.Point(103, 198);
            this.btnKulupSil.Name = "btnKulupSil";
            this.btnKulupSil.Size = new System.Drawing.Size(86, 25);
            this.btnKulupSil.TabIndex = 11;
            this.btnKulupSil.Text = "Sil";
            this.btnKulupSil.UseVisualStyleBackColor = false;
            this.btnKulupSil.Click += new System.EventHandler(this.btnKulupSil_Click);
            // 
            // btnKulupKaydet
            // 
            this.btnKulupKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKulupKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulupKaydet.Location = new System.Drawing.Point(195, 198);
            this.btnKulupKaydet.Name = "btnKulupKaydet";
            this.btnKulupKaydet.Size = new System.Drawing.Size(82, 25);
            this.btnKulupKaydet.TabIndex = 10;
            this.btnKulupKaydet.Text = "Kaydet";
            this.btnKulupKaydet.UseVisualStyleBackColor = false;
            this.btnKulupKaydet.Click += new System.EventHandler(this.btnKulupKaydet_Click);
            // 
            // lblKulupId
            // 
            this.lblKulupId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKulupId.Location = new System.Drawing.Point(6, 90);
            this.lblKulupId.Name = "lblKulupId";
            this.lblKulupId.Size = new System.Drawing.Size(87, 23);
            this.lblKulupId.TabIndex = 0;
            this.lblKulupId.Text = "KULÜP ID:";
            this.lblKulupId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKulupId
            // 
            this.txtKulupId.Enabled = false;
            this.txtKulupId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtKulupId.Location = new System.Drawing.Point(103, 87);
            this.txtKulupId.Name = "txtKulupId";
            this.txtKulupId.Size = new System.Drawing.Size(174, 23);
            this.txtKulupId.TabIndex = 9;
            // 
            // txtKulupAd
            // 
            this.txtKulupAd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtKulupAd.Location = new System.Drawing.Point(103, 118);
            this.txtKulupAd.Name = "txtKulupAd";
            this.txtKulupAd.Size = new System.Drawing.Size(174, 23);
            this.txtKulupAd.TabIndex = 8;
            // 
            // lblKulupAd
            // 
            this.lblKulupAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKulupAd.Location = new System.Drawing.Point(6, 121);
            this.lblKulupAd.Name = "lblKulupAd";
            this.lblKulupAd.Size = new System.Drawing.Size(87, 20);
            this.lblKulupAd.TabIndex = 1;
            this.lblKulupAd.Text = "KULÜP AD:";
            this.lblKulupAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(29, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 204);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1115, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKulup);
            this.Controls.Add(this.grpNotlar);
            this.Controls.Add(this.grpOgrBilgileri);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOgrBilgileri.ResumeLayout(false);
            this.grpOgrBilgileri.PerformLayout();
            this.grpNotlar.ResumeLayout(false);
            this.grpNotlar.PerformLayout();
            this.grpKulup.ResumeLayout(false);
            this.grpKulup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrBilgileri;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtFotograf;
        private System.Windows.Forms.ComboBox cmbKulup;
        private System.Windows.Forms.Label lblKulup;
        private System.Windows.Forms.Label lblFotograf;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.GroupBox grpNotlar;
        private System.Windows.Forms.Button btnNotListele;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.Label lblOgrId;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label lblSinav3;
        private System.Windows.Forms.Label lblSinav2;
        private System.Windows.Forms.Label lblSinav1;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.GroupBox grpKulup;
        private System.Windows.Forms.Button btnKulupListele;
        private System.Windows.Forms.Button btnKulupGuncelle;
        private System.Windows.Forms.Button btnKulupSil;
        private System.Windows.Forms.Button btnKulupKaydet;
        private System.Windows.Forms.Label lblKulupId;
        private System.Windows.Forms.TextBox txtKulupId;
        private System.Windows.Forms.TextBox txtKulupAd;
        private System.Windows.Forms.Label lblKulupAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

