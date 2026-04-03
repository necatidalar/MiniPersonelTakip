namespace MiniPersonelTakip
{
    partial class frm_PersonelDuzenle
    {
        private System.ComponentModel.IContainer components = null;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonelDuzenle));
            lblPersonelKod = new Label();
            txtPersonelKod = new TextBox();
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblDepartman = new Label();
            cmbDepartman = new ComboBox();
            lblPozisyon = new Label();
            cmbPozisyon = new ComboBox();
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
            SuspendLayout();
            // 
            // lblPersonelKod
            // 
            lblPersonelKod.AutoSize = true;
            lblPersonelKod.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonelKod.Location = new Point(32, 28);
            lblPersonelKod.Name = "lblPersonelKod";
            lblPersonelKod.Size = new Size(106, 19);
            lblPersonelKod.TabIndex = 0;
            lblPersonelKod.Text = "Personel Kodu";
            // 
            // txtPersonelKod
            // 
            txtPersonelKod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPersonelKod.Location = new Point(32, 50);
            txtPersonelKod.Name = "txtPersonelKod";
            txtPersonelKod.Size = new Size(320, 25);
            txtPersonelKod.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(32, 92);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 19);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(32, 114);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(320, 25);
            txtAd.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.Location = new Point(390, 92);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 19);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(390, 114);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(338, 25);
            txtSoyad.TabIndex = 5;
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDepartman.Location = new Point(32, 156);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(100, 19);
            lblDepartman.TabIndex = 6;
            lblDepartman.Text = "Departman";
            // 
            // cmbDepartman
            // 
            cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartman.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(32, 178);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(320, 25);
            cmbDepartman.TabIndex = 7;
            // 
            // lblPozisyon
            // 
            lblPozisyon.AutoSize = true;
            lblPozisyon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPozisyon.Location = new Point(390, 156);
            lblPozisyon.Name = "lblPozisyon";
            lblPozisyon.Size = new Size(84, 19);
            lblPozisyon.TabIndex = 8;
            lblPozisyon.Text = "Pozisyon";
            // 
            // cmbPozisyon
            // 
            cmbPozisyon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPozisyon.FormattingEnabled = true;
            cmbPozisyon.Location = new Point(390, 178);
            cmbPozisyon.Name = "cmbPozisyon";
            cmbPozisyon.Size = new Size(338, 25);
            cmbPozisyon.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTelefon.Location = new Point(32, 220);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(67, 19);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.Location = new Point(32, 242);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(320, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(390, 220);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(68, 19);
            lblEposta.TabIndex = 12;
            lblEposta.Text = "E-Posta";
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(390, 242);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(338, 25);
            txtEposta.TabIndex = 13;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdres.Location = new Point(32, 284);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(55, 19);
            lblAdres.TabIndex = 14;
            lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdres.Location = new Point(32, 306);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.Size = new Size(696, 88);
            txtAdres.TabIndex = 15;
            // 
            // lblIseGiris
            // 
            lblIseGiris.AutoSize = true;
            lblIseGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIseGiris.Location = new Point(32, 411);
            lblIseGiris.Name = "lblIseGiris";
            lblIseGiris.Size = new Size(119, 19);
            lblIseGiris.TabIndex = 16;
            lblIseGiris.Text = "İşe Giriş Tarihi";
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpIseGirisTarihi.Format = DateTimePickerFormat.Short;
            dtpIseGirisTarihi.Location = new Point(32, 433);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(170, 25);
            dtpIseGirisTarihi.TabIndex = 17;
            // 
            // chkAktifMi
            // 
            chkAktifMi.AutoSize = true;
            chkAktifMi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkAktifMi.Location = new Point(232, 433);
            chkAktifMi.Name = "chkAktifMi";
            chkAktifMi.Size = new Size(81, 23);
            chkAktifMi.TabIndex = 18;
            chkAktifMi.Text = "Aktif Mi";
            chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(538, 489);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 38);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.BackColor = Color.FromArgb(149, 165, 166);
            btnIptal.FlatAppearance.BorderSize = 0;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(636, 489);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(92, 38);
            btnIptal.TabIndex = 20;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // frm_PersonelDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 550);
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
            Controls.Add(cmbPozisyon);
            Controls.Add(lblPozisyon);
            Controls.Add(cmbDepartman);
            Controls.Add(lblDepartman);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Controls.Add(txtPersonelKod);
            Controls.Add(lblPersonelKod);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(776, 589);
            Name = "frm_PersonelDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Düzenle";
            Load += frm_PersonelDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
