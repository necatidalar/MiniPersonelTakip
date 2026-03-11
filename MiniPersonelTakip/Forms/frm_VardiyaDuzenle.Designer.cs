namespace MiniPersonelTakip
{
    partial class frm_VardiyaDuzenle
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VardiyaDuzenle));
            lblPersonel = new Label();
            cmbPersonel = new ComboBox();
            lblTarih = new Label();
            dtpTarih = new DateTimePicker();
            lblPlanlananGiris = new Label();
            dtpPlanlananGiris = new DateTimePicker();
            lblPlanlananCikis = new Label();
            dtpPlanlananCikis = new DateTimePicker();
            chkGercekSaatlerGirilsin = new CheckBox();
            lblGercekGiris = new Label();
            dtpGercekGiris = new DateTimePicker();
            lblGercekCikis = new Label();
            dtpGercekCikis = new DateTimePicker();
            lblVardiyaTipi = new Label();
            cmbVardiyaTipi = new ComboBox();
            lblDurum = new Label();
            cmbDurum = new ComboBox();
            lblAciklama = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPersonel.Location = new Point(28, 22);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(67, 19);
            lblPersonel.TabIndex = 0;
            lblPersonel.Text = "Personel";
            // 
            // cmbPersonel
            // 
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.Font = new Font("Segoe UI", 10F);
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(28, 44);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(300, 25);
            cmbPersonel.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarih.Location = new Point(28, 84);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(42, 19);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 10F);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(28, 106);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(300, 25);
            dtpTarih.TabIndex = 3;
            // 
            // lblPlanlananGiris
            // 
            lblPlanlananGiris.AutoSize = true;
            lblPlanlananGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlanlananGiris.Location = new Point(28, 146);
            lblPlanlananGiris.Name = "lblPlanlananGiris";
            lblPlanlananGiris.Size = new Size(108, 19);
            lblPlanlananGiris.TabIndex = 4;
            lblPlanlananGiris.Text = "Planlanan Giriş";
            // 
            // dtpPlanlananGiris
            // 
            dtpPlanlananGiris.Font = new Font("Segoe UI", 10F);
            dtpPlanlananGiris.Location = new Point(28, 168);
            dtpPlanlananGiris.Name = "dtpPlanlananGiris";
            dtpPlanlananGiris.Size = new Size(300, 25);
            dtpPlanlananGiris.TabIndex = 5;
            // 
            // lblPlanlananCikis
            // 
            lblPlanlananCikis.AutoSize = true;
            lblPlanlananCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlanlananCikis.Location = new Point(28, 208);
            lblPlanlananCikis.Name = "lblPlanlananCikis";
            lblPlanlananCikis.Size = new Size(109, 19);
            lblPlanlananCikis.TabIndex = 6;
            lblPlanlananCikis.Text = "Planlanan Çıkış";
            // 
            // dtpPlanlananCikis
            // 
            dtpPlanlananCikis.Font = new Font("Segoe UI", 10F);
            dtpPlanlananCikis.Location = new Point(28, 230);
            dtpPlanlananCikis.Name = "dtpPlanlananCikis";
            dtpPlanlananCikis.Size = new Size(300, 25);
            dtpPlanlananCikis.TabIndex = 7;
            // 
            // chkGercekSaatlerGirilsin
            // 
            chkGercekSaatlerGirilsin.AutoSize = true;
            chkGercekSaatlerGirilsin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkGercekSaatlerGirilsin.Location = new Point(28, 274);
            chkGercekSaatlerGirilsin.Name = "chkGercekSaatlerGirilsin";
            chkGercekSaatlerGirilsin.Size = new Size(176, 23);
            chkGercekSaatlerGirilsin.TabIndex = 8;
            chkGercekSaatlerGirilsin.Text = "Gerçek Saatler Girilsin";
            chkGercekSaatlerGirilsin.UseVisualStyleBackColor = true;
            chkGercekSaatlerGirilsin.CheckedChanged += chkGercekSaatlerGirilsin_CheckedChanged;
            // 
            // lblGercekGiris
            // 
            lblGercekGiris.AutoSize = true;
            lblGercekGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGercekGiris.Location = new Point(28, 312);
            lblGercekGiris.Name = "lblGercekGiris";
            lblGercekGiris.Size = new Size(90, 19);
            lblGercekGiris.TabIndex = 9;
            lblGercekGiris.Text = "Gerçek Giriş";
            // 
            // dtpGercekGiris
            // 
            dtpGercekGiris.Font = new Font("Segoe UI", 10F);
            dtpGercekGiris.Location = new Point(28, 334);
            dtpGercekGiris.Name = "dtpGercekGiris";
            dtpGercekGiris.Size = new Size(300, 25);
            dtpGercekGiris.TabIndex = 10;
            // 
            // lblGercekCikis
            // 
            lblGercekCikis.AutoSize = true;
            lblGercekCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGercekCikis.Location = new Point(28, 374);
            lblGercekCikis.Name = "lblGercekCikis";
            lblGercekCikis.Size = new Size(91, 19);
            lblGercekCikis.TabIndex = 11;
            lblGercekCikis.Text = "Gerçek Çıkış";
            // 
            // dtpGercekCikis
            // 
            dtpGercekCikis.Font = new Font("Segoe UI", 10F);
            dtpGercekCikis.Location = new Point(28, 396);
            dtpGercekCikis.Name = "dtpGercekCikis";
            dtpGercekCikis.Size = new Size(300, 25);
            dtpGercekCikis.TabIndex = 12;
            // 
            // lblVardiyaTipi
            // 
            lblVardiyaTipi.AutoSize = true;
            lblVardiyaTipi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVardiyaTipi.Location = new Point(28, 436);
            lblVardiyaTipi.Name = "lblVardiyaTipi";
            lblVardiyaTipi.Size = new Size(89, 19);
            lblVardiyaTipi.TabIndex = 13;
            lblVardiyaTipi.Text = "Vardiya Tipi";
            // 
            // cmbVardiyaTipi
            // 
            cmbVardiyaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVardiyaTipi.Font = new Font("Segoe UI", 10F);
            cmbVardiyaTipi.FormattingEnabled = true;
            cmbVardiyaTipi.Location = new Point(28, 458);
            cmbVardiyaTipi.Name = "cmbVardiyaTipi";
            cmbVardiyaTipi.Size = new Size(300, 25);
            cmbVardiyaTipi.TabIndex = 14;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDurum.Location = new Point(28, 498);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 15;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Font = new Font("Segoe UI", 10F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(28, 520);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(300, 25);
            cmbDurum.TabIndex = 16;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAciklama.Location = new Point(28, 560);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(71, 19);
            lblAciklama.TabIndex = 17;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 10F);
            txtAciklama.Location = new Point(28, 582);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Size = new Size(300, 80);
            txtAciklama.TabIndex = 18;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(28, 679);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(144, 40);
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
            btnIptal.Location = new Point(184, 679);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(144, 40);
            btnIptal.TabIndex = 20;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // frm_VardiyaDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 744);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(cmbDurum);
            Controls.Add(lblDurum);
            Controls.Add(cmbVardiyaTipi);
            Controls.Add(lblVardiyaTipi);
            Controls.Add(dtpGercekCikis);
            Controls.Add(lblGercekCikis);
            Controls.Add(dtpGercekGiris);
            Controls.Add(lblGercekGiris);
            Controls.Add(chkGercekSaatlerGirilsin);
            Controls.Add(dtpPlanlananCikis);
            Controls.Add(lblPlanlananCikis);
            Controls.Add(dtpPlanlananGiris);
            Controls.Add(lblPlanlananGiris);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            Controls.Add(cmbPersonel);
            Controls.Add(lblPersonel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_VardiyaDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vardiya Düzenle";
            Load += frm_VardiyaDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPersonel;
        private ComboBox cmbPersonel;
        private Label lblTarih;
        private DateTimePicker dtpTarih;
        private Label lblPlanlananGiris;
        private DateTimePicker dtpPlanlananGiris;
        private Label lblPlanlananCikis;
        private DateTimePicker dtpPlanlananCikis;
        private CheckBox chkGercekSaatlerGirilsin;
        private Label lblGercekGiris;
        private DateTimePicker dtpGercekGiris;
        private Label lblGercekCikis;
        private DateTimePicker dtpGercekCikis;
        private Label lblVardiyaTipi;
        private ComboBox cmbVardiyaTipi;
        private Label lblDurum;
        private ComboBox cmbDurum;
        private Label lblAciklama;
        private TextBox txtAciklama;
        private Button btnKaydet;
        private Button btnIptal;
    }
}