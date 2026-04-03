namespace MiniPersonelTakip.Forms
{
    partial class frm_GorevDuzenle
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPersonel;
        private ComboBox cmbPersonel;
        private Label lblBaslik;
        private TextBox txtGorevBasligi;
        private Label lblDetay;
        private TextBox txtGorevDetayi;
        private Label lblBaslangic;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private DateTimePicker dtpBitis;
        private CheckBox chkBitisTarihi;
        private Label lblOncelik;
        private ComboBox cmbOncelik;
        private Label lblDurum;
        private ComboBox cmbDurum;
        private Button btnKaydet;
        private Button btnIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GorevDuzenle));
            lblPersonel = new Label();
            cmbPersonel = new ComboBox();
            lblBaslik = new Label();
            txtGorevBasligi = new TextBox();
            lblDetay = new Label();
            txtGorevDetayi = new TextBox();
            lblBaslangic = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBitis = new Label();
            dtpBitis = new DateTimePicker();
            chkBitisTarihi = new CheckBox();
            lblOncelik = new Label();
            cmbOncelik = new ComboBox();
            lblDurum = new Label();
            cmbDurum = new ComboBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonel.ForeColor = Color.FromArgb(170, 175, 185);
            lblPersonel.Location = new Point(32, 28);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(67, 19);
            lblPersonel.TabIndex = 0;
            lblPersonel.Text = "Personel";
            // 
            // cmbPersonel
            // 
            cmbPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPersonel.BackColor = Color.FromArgb(35, 38, 45);
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.FlatStyle = FlatStyle.Flat;
            cmbPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPersonel.ForeColor = Color.White;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(32, 50);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(696, 25);
            cmbPersonel.TabIndex = 1;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(170, 175, 185);
            lblBaslik.Location = new Point(32, 92);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(98, 19);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "Görev Başlığı";
            // 
            // txtGorevBasligi
            // 
            txtGorevBasligi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGorevBasligi.BackColor = Color.FromArgb(35, 38, 45);
            txtGorevBasligi.BorderStyle = BorderStyle.FixedSingle;
            txtGorevBasligi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGorevBasligi.ForeColor = Color.White;
            txtGorevBasligi.Location = new Point(32, 114);
            txtGorevBasligi.Name = "txtGorevBasligi";
            txtGorevBasligi.Size = new Size(696, 25);
            txtGorevBasligi.TabIndex = 3;
            // 
            // lblDetay
            // 
            lblDetay.AutoSize = true;
            lblDetay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDetay.ForeColor = Color.FromArgb(170, 175, 185);
            lblDetay.Location = new Point(32, 156);
            lblDetay.Name = "lblDetay";
            lblDetay.Size = new Size(97, 19);
            lblDetay.TabIndex = 4;
            lblDetay.Text = "Görev Detayı";
            // 
            // txtGorevDetayi
            // 
            txtGorevDetayi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGorevDetayi.BackColor = Color.FromArgb(35, 38, 45);
            txtGorevDetayi.BorderStyle = BorderStyle.FixedSingle;
            txtGorevDetayi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGorevDetayi.ForeColor = Color.White;
            txtGorevDetayi.Location = new Point(32, 178);
            txtGorevDetayi.Multiline = true;
            txtGorevDetayi.Name = "txtGorevDetayi";
            txtGorevDetayi.ScrollBars = ScrollBars.Vertical;
            txtGorevDetayi.Size = new Size(696, 110);
            txtGorevDetayi.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslangic.ForeColor = Color.FromArgb(170, 175, 185);
            lblBaslangic.Location = new Point(32, 308);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(113, 19);
            lblBaslangic.TabIndex = 6;
            lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(32, 330);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(160, 24);
            dtpBaslangic.TabIndex = 7;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBitis.ForeColor = Color.FromArgb(170, 175, 185);
            lblBitis.Location = new Point(214, 308);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(78, 19);
            lblBitis.TabIndex = 8;
            lblBitis.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(214, 330);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(160, 24);
            dtpBitis.TabIndex = 9;
            // 
            // chkBitisTarihi
            // 
            chkBitisTarihi.AutoSize = true;
            chkBitisTarihi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkBitisTarihi.ForeColor = Color.FromArgb(170, 175, 185);
            chkBitisTarihi.Location = new Point(398, 331);
            chkBitisTarihi.Name = "chkBitisTarihi";
            chkBitisTarihi.Size = new Size(125, 23);
            chkBitisTarihi.TabIndex = 10;
            chkBitisTarihi.Text = "Bitiş tarihi olsun";
            chkBitisTarihi.UseVisualStyleBackColor = true;
            // 
            // lblOncelik
            // 
            lblOncelik.AutoSize = true;
            lblOncelik.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOncelik.ForeColor = Color.FromArgb(170, 175, 185);
            lblOncelik.Location = new Point(32, 373);
            lblOncelik.Name = "lblOncelik";
            lblOncelik.Size = new Size(59, 19);
            lblOncelik.TabIndex = 11;
            lblOncelik.Text = "Öncelik";
            // 
            // cmbOncelik
            // 
            cmbOncelik.BackColor = Color.FromArgb(35, 38, 45);
            cmbOncelik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOncelik.FlatStyle = FlatStyle.Flat;
            cmbOncelik.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbOncelik.ForeColor = Color.White;
            cmbOncelik.FormattingEnabled = true;
            cmbOncelik.Location = new Point(32, 395);
            cmbOncelik.Name = "cmbOncelik";
            cmbOncelik.Size = new Size(214, 25);
            cmbOncelik.TabIndex = 12;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = Color.FromArgb(170, 175, 185);
            lblDurum.Location = new Point(272, 373);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.BackColor = Color.FromArgb(35, 38, 45);
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FlatStyle = FlatStyle.Flat;
            cmbDurum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDurum.ForeColor = Color.White;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(272, 395);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(214, 25);
            cmbDurum.TabIndex = 14;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(542, 448);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 36);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.BackColor = Color.FromArgb(44, 62, 80);
            btnIptal.FlatAppearance.BorderSize = 0;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(638, 448);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(90, 36);
            btnIptal.TabIndex = 16;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // frm_GorevDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(760, 505);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(cmbDurum);
            Controls.Add(lblDurum);
            Controls.Add(cmbOncelik);
            Controls.Add(lblOncelik);
            Controls.Add(chkBitisTarihi);
            Controls.Add(dtpBitis);
            Controls.Add(lblBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lblBaslangic);
            Controls.Add(txtGorevDetayi);
            Controls.Add(lblDetay);
            Controls.Add(txtGorevBasligi);
            Controls.Add(lblBaslik);
            Controls.Add(cmbPersonel);
            Controls.Add(lblPersonel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(776, 544);
            Name = "frm_GorevDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Görev Düzenle";
            Load += frm_GorevDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}