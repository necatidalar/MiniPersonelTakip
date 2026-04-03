namespace MiniPersonelTakip
{
    partial class frm_VardiyaDuzenle
    {
        private System.ComponentModel.IContainer components = null;

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
            lblPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonel.Location = new Point(32, 28);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(67, 19);
            lblPersonel.TabIndex = 0;
            lblPersonel.Text = "Personel";
            // 
            // cmbPersonel
            // 
            cmbPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(32, 50);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(696, 25);
            cmbPersonel.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTarih.Location = new Point(32, 92);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(42, 19);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(32, 114);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(150, 25);
            dtpTarih.TabIndex = 3;
            // 
            // lblVardiyaTipi
            // 
            lblVardiyaTipi.AutoSize = true;
            lblVardiyaTipi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblVardiyaTipi.Location = new Point(212, 92);
            lblVardiyaTipi.Name = "lblVardiyaTipi";
            lblVardiyaTipi.Size = new Size(105, 19);
            lblVardiyaTipi.TabIndex = 4;
            lblVardiyaTipi.Text = "Vardiya Tipi";
            // 
            // cmbVardiyaTipi
            // 
            cmbVardiyaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVardiyaTipi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbVardiyaTipi.FormattingEnabled = true;
            cmbVardiyaTipi.Location = new Point(212, 114);
            cmbVardiyaTipi.Name = "cmbVardiyaTipi";
            cmbVardiyaTipi.Size = new Size(220, 25);
            cmbVardiyaTipi.TabIndex = 5;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.Location = new Point(458, 92);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 6;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(458, 114);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(270, 25);
            cmbDurum.TabIndex = 7;
            // 
            // lblPlanlananGiris
            // 
            lblPlanlananGiris.AutoSize = true;
            lblPlanlananGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPlanlananGiris.Location = new Point(32, 160);
            lblPlanlananGiris.Name = "lblPlanlananGiris";
            lblPlanlananGiris.Size = new Size(127, 19);
            lblPlanlananGiris.TabIndex = 8;
            lblPlanlananGiris.Text = "Planlanan Giriş";
            // 
            // dtpPlanlananGiris
            // 
            dtpPlanlananGiris.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpPlanlananGiris.Location = new Point(32, 182);
            dtpPlanlananGiris.Name = "dtpPlanlananGiris";
            dtpPlanlananGiris.Size = new Size(160, 25);
            dtpPlanlananGiris.TabIndex = 9;
            // 
            // lblPlanlananCikis
            // 
            lblPlanlananCikis.AutoSize = true;
            lblPlanlananCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPlanlananCikis.Location = new Point(212, 160);
            lblPlanlananCikis.Name = "lblPlanlananCikis";
            lblPlanlananCikis.Size = new Size(128, 19);
            lblPlanlananCikis.TabIndex = 10;
            lblPlanlananCikis.Text = "Planlanan Çıkış";
            // 
            // dtpPlanlananCikis
            // 
            dtpPlanlananCikis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpPlanlananCikis.Location = new Point(212, 182);
            dtpPlanlananCikis.Name = "dtpPlanlananCikis";
            dtpPlanlananCikis.Size = new Size(160, 25);
            dtpPlanlananCikis.TabIndex = 11;
            // 
            // chkGercekSaatlerGirilsin
            // 
            chkGercekSaatlerGirilsin.AutoSize = true;
            chkGercekSaatlerGirilsin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkGercekSaatlerGirilsin.Location = new Point(32, 228);
            chkGercekSaatlerGirilsin.Name = "chkGercekSaatlerGirilsin";
            chkGercekSaatlerGirilsin.Size = new Size(187, 23);
            chkGercekSaatlerGirilsin.TabIndex = 12;
            chkGercekSaatlerGirilsin.Text = "Gerçek saatler girilsin";
            chkGercekSaatlerGirilsin.UseVisualStyleBackColor = true;
            chkGercekSaatlerGirilsin.CheckedChanged += chkGercekSaatlerGirilsin_CheckedChanged;
            // 
            // lblGercekGiris
            // 
            lblGercekGiris.AutoSize = true;
            lblGercekGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGercekGiris.Location = new Point(32, 268);
            lblGercekGiris.Name = "lblGercekGiris";
            lblGercekGiris.Size = new Size(109, 19);
            lblGercekGiris.TabIndex = 13;
            lblGercekGiris.Text = "Gerçek Giriş";
            // 
            // dtpGercekGiris
            // 
            dtpGercekGiris.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpGercekGiris.Location = new Point(32, 290);
            dtpGercekGiris.Name = "dtpGercekGiris";
            dtpGercekGiris.Size = new Size(160, 25);
            dtpGercekGiris.TabIndex = 14;
            // 
            // lblGercekCikis
            // 
            lblGercekCikis.AutoSize = true;
            lblGercekCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGercekCikis.Location = new Point(212, 268);
            lblGercekCikis.Name = "lblGercekCikis";
            lblGercekCikis.Size = new Size(110, 19);
            lblGercekCikis.TabIndex = 15;
            lblGercekCikis.Text = "Gerçek Çıkış";
            // 
            // dtpGercekCikis
            // 
            dtpGercekCikis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpGercekCikis.Location = new Point(212, 290);
            dtpGercekCikis.Name = "dtpGercekCikis";
            dtpGercekCikis.Size = new Size(160, 25);
            dtpGercekCikis.TabIndex = 16;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAciklama.Location = new Point(32, 340);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(71, 19);
            lblAciklama.TabIndex = 17;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAciklama.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAciklama.Location = new Point(32, 362);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Size = new Size(696, 90);
            txtAciklama.TabIndex = 18;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(540, 478);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 38);
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
            btnIptal.Location = new Point(638, 478);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(90, 38);
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
            ClientSize = new Size(760, 540);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(dtpGercekCikis);
            Controls.Add(lblGercekCikis);
            Controls.Add(dtpGercekGiris);
            Controls.Add(lblGercekGiris);
            Controls.Add(chkGercekSaatlerGirilsin);
            Controls.Add(dtpPlanlananCikis);
            Controls.Add(lblPlanlananCikis);
            Controls.Add(dtpPlanlananGiris);
            Controls.Add(lblPlanlananGiris);
            Controls.Add(cmbDurum);
            Controls.Add(lblDurum);
            Controls.Add(cmbVardiyaTipi);
            Controls.Add(lblVardiyaTipi);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            Controls.Add(cmbPersonel);
            Controls.Add(lblPersonel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(776, 579);
            Name = "frm_VardiyaDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vardiya Düzenle";
            Load += frm_VardiyaDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
