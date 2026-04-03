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
            lblPersonelKod.ForeColor = Color.FromArgb(170, 175, 185);
            lblPersonelKod.Location = new Point(32, 28);
            lblPersonelKod.Name = "lblPersonelKod";
            lblPersonelKod.Size = new Size(106, 19);
            lblPersonelKod.TabIndex = 0;
            lblPersonelKod.Text = "Personel Kodu";
            // 
            // txtPersonelKod
            // 
            txtPersonelKod.BackColor = Color.FromArgb(35, 38, 45);
            txtPersonelKod.BorderStyle = BorderStyle.FixedSingle;
            txtPersonelKod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPersonelKod.ForeColor = Color.White;
            txtPersonelKod.Location = new Point(32, 50);
            txtPersonelKod.Name = "txtPersonelKod";
            txtPersonelKod.Size = new Size(320, 25);
            txtPersonelKod.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.FromArgb(170, 175, 185);
            lblAd.Location = new Point(32, 92);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 19);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(35, 38, 45);
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.White;
            txtAd.Location = new Point(32, 114);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(320, 25);
            txtAd.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.FromArgb(170, 175, 185);
            lblSoyad.Location = new Point(390, 92);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 19);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(35, 38, 45);
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = Color.White;
            txtSoyad.Location = new Point(390, 114);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(338, 25);
            txtSoyad.TabIndex = 5;
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDepartman.ForeColor = Color.FromArgb(170, 175, 185);
            lblDepartman.Location = new Point(32, 156);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(84, 19);
            lblDepartman.TabIndex = 6;
            lblDepartman.Text = "Departman";
            // 
            // cmbDepartman
            // 
            cmbDepartman.BackColor = Color.FromArgb(35, 38, 45);
            cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartman.FlatStyle = FlatStyle.Flat;
            cmbDepartman.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDepartman.ForeColor = Color.White;
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
            lblPozisyon.ForeColor = Color.FromArgb(170, 175, 185);
            lblPozisyon.Location = new Point(390, 156);
            lblPozisyon.Name = "lblPozisyon";
            lblPozisyon.Size = new Size(69, 19);
            lblPozisyon.TabIndex = 8;
            lblPozisyon.Text = "Pozisyon";
            // 
            // cmbPozisyon
            // 
            cmbPozisyon.BackColor = Color.FromArgb(35, 38, 45);
            cmbPozisyon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyon.FlatStyle = FlatStyle.Flat;
            cmbPozisyon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPozisyon.ForeColor = Color.White;
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
            lblTelefon.ForeColor = Color.FromArgb(170, 175, 185);
            lblTelefon.Location = new Point(32, 220);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 19);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.FromArgb(35, 38, 45);
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.ForeColor = Color.White;
            txtTelefon.Location = new Point(32, 242);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(320, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.ForeColor = Color.FromArgb(170, 175, 185);
            lblEposta.Location = new Point(390, 220);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(59, 19);
            lblEposta.TabIndex = 12;
            lblEposta.Text = "E-Posta";
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.FromArgb(35, 38, 45);
            txtEposta.BorderStyle = BorderStyle.FixedSingle;
            txtEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEposta.ForeColor = Color.White;
            txtEposta.Location = new Point(390, 242);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(338, 25);
            txtEposta.TabIndex = 13;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdres.ForeColor = Color.FromArgb(170, 175, 185);
            lblAdres.Location = new Point(32, 284);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(48, 19);
            lblAdres.TabIndex = 14;
            lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdres.BackColor = Color.FromArgb(35, 38, 45);
            txtAdres.BorderStyle = BorderStyle.FixedSingle;
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdres.ForeColor = Color.White;
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
            lblIseGiris.ForeColor = Color.FromArgb(170, 175, 185);
            lblIseGiris.Location = new Point(32, 411);
            lblIseGiris.Name = "lblIseGiris";
            lblIseGiris.Size = new Size(102, 19);
            lblIseGiris.TabIndex = 16;
            lblIseGiris.Text = "İşe Giriş Tarihi";
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpIseGirisTarihi.Format = DateTimePickerFormat.Short;
            dtpIseGirisTarihi.Location = new Point(32, 433);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(170, 24);
            dtpIseGirisTarihi.TabIndex = 17;
            // 
            // chkAktifMi
            // 
            chkAktifMi.AutoSize = true;
            chkAktifMi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkAktifMi.ForeColor = Color.FromArgb(170, 175, 185);
            chkAktifMi.Location = new Point(232, 433);
            chkAktifMi.Name = "chkAktifMi";
            chkAktifMi.Size = new Size(76, 23);
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
            btnIptal.BackColor = Color.FromArgb(44, 62, 80);
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
            BackColor = Color.FromArgb(18, 18, 18);
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