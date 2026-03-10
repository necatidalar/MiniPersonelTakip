namespace MiniPersonelTakip
{
    partial class frm_PersonelDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources are disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPersonelKod = new Label();
            txtPersonelKod = new TextBox();
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblDepartman = new Label();
            lblPozisyon = new Label();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblEposta = new Label();
            txtEposta = new TextBox();
            lblAdres = new Label();
            txtAdres = new TextBox();
            lblIseGiris = new Label();
            dtpIseGirisTarihi = new DateTimePicker();
            chkAktifMi = new CheckBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            cmbDepartman = new ComboBox();
            cmbPozisyon = new ComboBox();
            SuspendLayout();
            // 
            // lblPersonelKod
            // 
            lblPersonelKod.AutoSize = true;
            lblPersonelKod.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPersonelKod.Location = new Point(28, 24);
            lblPersonelKod.Name = "lblPersonelKod";
            lblPersonelKod.Size = new Size(106, 19);
            lblPersonelKod.TabIndex = 0;
            lblPersonelKod.Text = "Personel Kodu";
            // 
            // txtPersonelKod
            // 
            txtPersonelKod.Font = new Font("Segoe UI", 10F);
            txtPersonelKod.Location = new Point(28, 46);
            txtPersonelKod.Name = "txtPersonelKod";
            txtPersonelKod.Size = new Size(220, 25);
            txtPersonelKod.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAd.Location = new Point(28, 86);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 19);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.Location = new Point(28, 108);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 25);
            txtAd.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoyad.Location = new Point(28, 148);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 19);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.Location = new Point(28, 170);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 25);
            txtSoyad.TabIndex = 5;
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDepartman.Location = new Point(28, 210);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(84, 19);
            lblDepartman.TabIndex = 6;
            lblDepartman.Text = "Departman";
            // 
            // lblPozisyon
            // 
            lblPozisyon.AutoSize = true;
            lblPozisyon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPozisyon.Location = new Point(28, 272);
            lblPozisyon.Name = "lblPozisyon";
            lblPozisyon.Size = new Size(69, 19);
            lblPozisyon.TabIndex = 8;
            lblPozisyon.Text = "Pozisyon";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.Location = new Point(28, 334);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 19);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(28, 356);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEposta.Location = new Point(28, 396);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(59, 19);
            lblEposta.TabIndex = 12;
            lblEposta.Text = "E-Posta";
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 10F);
            txtEposta.Location = new Point(28, 418);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(220, 25);
            txtEposta.TabIndex = 13;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdres.Location = new Point(28, 458);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(48, 19);
            lblAdres.TabIndex = 14;
            lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F);
            txtAdres.Location = new Point(28, 480);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.Size = new Size(220, 70);
            txtAdres.TabIndex = 15;
            // 
            // lblIseGiris
            // 
            lblIseGiris.AutoSize = true;
            lblIseGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIseGiris.Location = new Point(28, 565);
            lblIseGiris.Name = "lblIseGiris";
            lblIseGiris.Size = new Size(102, 19);
            lblIseGiris.TabIndex = 16;
            lblIseGiris.Text = "İşe Giriş Tarihi";
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Font = new Font("Segoe UI", 10F);
            dtpIseGirisTarihi.Format = DateTimePickerFormat.Short;
            dtpIseGirisTarihi.Location = new Point(28, 587);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(220, 25);
            dtpIseGirisTarihi.TabIndex = 17;
            // 
            // chkAktifMi
            // 
            chkAktifMi.AutoSize = true;
            chkAktifMi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkAktifMi.Location = new Point(28, 627);
            chkAktifMi.Name = "chkAktifMi";
            chkAktifMi.Size = new Size(81, 23);
            chkAktifMi.TabIndex = 18;
            chkAktifMi.Text = "Aktif Mi";
            chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(28, 669);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(106, 38);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(149, 165, 166);
            btnIptal.FlatAppearance.BorderSize = 0;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(142, 669);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(106, 38);
            btnIptal.TabIndex = 20;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // cmbDepartman
            // 
            cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartman.Font = new Font("Segoe UI", 10F);
            cmbDepartman.Location = new Point(28, 232);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(220, 25);
            cmbDepartman.TabIndex = 7;
            // 
            // cmbPozisyon
            // 
            cmbPozisyon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyon.Font = new Font("Segoe UI", 10F);
            cmbPozisyon.Location = new Point(28, 294);
            cmbPozisyon.Name = "cmbPozisyon";
            cmbPozisyon.Size = new Size(220, 25);
            cmbPozisyon.TabIndex = 9;
            // 
            // frm_PersonelDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(282, 727);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(chkAktifMi);
            Controls.Add(dtpIseGirisTarihi);
            Controls.Add(lblIseGiris);
            Controls.Add(txtAdres);
            Controls.Add(lblAdres);
            Controls.Add(txtEposta);
            Controls.Add(lblEposta);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(lblPozisyon);
            Controls.Add(lblDepartman);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Controls.Add(txtPersonelKod);
            Controls.Add(lblPersonelKod);
            Controls.Add(cmbDepartman);
            Controls.Add(cmbPozisyon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_PersonelDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Düzenle";
            Load += frm_PersonelDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersonelKod;
        private TextBox txtPersonelKod;
        private Label lblAd;
        private TextBox txtAd;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblDepartman;
        private Label lblPozisyon;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblEposta;
        private TextBox txtEposta;
        private Label lblAdres;
        private TextBox txtAdres;
        private Label lblIseGiris;
        private DateTimePicker dtpIseGirisTarihi;
        private CheckBox chkAktifMi;
        private Button btnKaydet;
        private Button btnIptal;
        private ComboBox cmbDepartman;
        private ComboBox cmbPozisyon;
    }
}