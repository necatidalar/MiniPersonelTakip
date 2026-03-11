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
            lblPersonel.Location = new Point(30, 25);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(52, 15);
            lblPersonel.TabIndex = 16;
            lblPersonel.Text = "Personel";
            // 
            // cmbPersonel
            // 
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(160, 22);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(350, 23);
            cmbPersonel.TabIndex = 15;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(30, 65);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(75, 15);
            lblBaslik.TabIndex = 14;
            lblBaslik.Text = "Görev Başlığı";
            // 
            // txtGorevBasligi
            // 
            txtGorevBasligi.Location = new Point(160, 62);
            txtGorevBasligi.Name = "txtGorevBasligi";
            txtGorevBasligi.Size = new Size(350, 23);
            txtGorevBasligi.TabIndex = 13;
            // 
            // lblDetay
            // 
            lblDetay.AutoSize = true;
            lblDetay.Location = new Point(30, 105);
            lblDetay.Name = "lblDetay";
            lblDetay.Size = new Size(74, 15);
            lblDetay.TabIndex = 12;
            lblDetay.Text = "Görev Detayı";
            // 
            // txtGorevDetayi
            // 
            txtGorevDetayi.Location = new Point(160, 102);
            txtGorevDetayi.Multiline = true;
            txtGorevDetayi.Name = "txtGorevDetayi";
            txtGorevDetayi.Size = new Size(350, 100);
            txtGorevDetayi.TabIndex = 11;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(30, 220);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(88, 15);
            lblBaslangic.TabIndex = 10;
            lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(160, 217);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(140, 23);
            dtpBaslangic.TabIndex = 9;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(30, 258);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(60, 15);
            lblBitis.TabIndex = 8;
            lblBitis.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(160, 255);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(140, 23);
            dtpBitis.TabIndex = 7;
            // 
            // chkBitisTarihi
            // 
            chkBitisTarihi.AutoSize = true;
            chkBitisTarihi.Location = new Point(320, 257);
            chkBitisTarihi.Name = "chkBitisTarihi";
            chkBitisTarihi.Size = new Size(110, 19);
            chkBitisTarihi.TabIndex = 6;
            chkBitisTarihi.Text = "Bitiş tarihi olsun";
            chkBitisTarihi.UseVisualStyleBackColor = true;
            // 
            // lblOncelik
            // 
            lblOncelik.AutoSize = true;
            lblOncelik.Location = new Point(30, 296);
            lblOncelik.Name = "lblOncelik";
            lblOncelik.Size = new Size(47, 15);
            lblOncelik.TabIndex = 5;
            lblOncelik.Text = "Öncelik";
            // 
            // cmbOncelik
            // 
            cmbOncelik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOncelik.FormattingEnabled = true;
            cmbOncelik.Location = new Point(160, 293);
            cmbOncelik.Name = "cmbOncelik";
            cmbOncelik.Size = new Size(200, 23);
            cmbOncelik.TabIndex = 4;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(30, 334);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 15);
            lblDurum.TabIndex = 3;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(160, 331);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(200, 23);
            cmbDurum.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(334, 385);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(85, 32);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(425, 385);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(85, 32);
            btnIptal.TabIndex = 0;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // frm_GorevDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 440);
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
            Name = "frm_GorevDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Görev Düzenle";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}