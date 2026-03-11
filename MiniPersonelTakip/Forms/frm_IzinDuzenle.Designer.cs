namespace MiniPersonelTakip.Forms
{
    partial class frm_IzinDuzenle
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPersonel;
        private ComboBox cmbPersonel;
        private Label lblIzinTuru;
        private ComboBox cmbIzinTuru;
        private Label lblDurum;
        private ComboBox cmbDurum;
        private Label lblBaslangic;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private DateTimePicker dtpBitis;
        private Label lblAciklama;
        private TextBox txtAciklama;
        private Label lblGunSayisi;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IzinDuzenle));
            lblPersonel = new Label();
            cmbPersonel = new ComboBox();
            lblIzinTuru = new Label();
            cmbIzinTuru = new ComboBox();
            lblDurum = new Label();
            cmbDurum = new ComboBox();
            lblBaslangic = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBitis = new Label();
            dtpBitis = new DateTimePicker();
            lblAciklama = new Label();
            txtAciklama = new TextBox();
            lblGunSayisi = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Location = new Point(30, 30);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(52, 15);
            lblPersonel.TabIndex = 0;
            lblPersonel.Text = "Personel";
            // 
            // cmbPersonel
            // 
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(170, 27);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(320, 23);
            cmbPersonel.TabIndex = 1;
            // 
            // lblIzinTuru
            // 
            lblIzinTuru.AutoSize = true;
            lblIzinTuru.Location = new Point(30, 75);
            lblIzinTuru.Name = "lblIzinTuru";
            lblIzinTuru.Size = new Size(52, 15);
            lblIzinTuru.TabIndex = 2;
            lblIzinTuru.Text = "İzin Türü";
            // 
            // cmbIzinTuru
            // 
            cmbIzinTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzinTuru.FormattingEnabled = true;
            cmbIzinTuru.Location = new Point(170, 72);
            cmbIzinTuru.Name = "cmbIzinTuru";
            cmbIzinTuru.Size = new Size(320, 23);
            cmbIzinTuru.TabIndex = 3;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(30, 120);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 15);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(170, 117);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(320, 23);
            cmbDurum.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(30, 165);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(88, 15);
            lblBaslangic.TabIndex = 6;
            lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(170, 160);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(150, 23);
            dtpBaslangic.TabIndex = 7;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(30, 210);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(60, 15);
            lblBitis.TabIndex = 8;
            lblBitis.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(170, 205);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(150, 23);
            dtpBitis.TabIndex = 9;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(30, 255);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(56, 15);
            lblAciklama.TabIndex = 10;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(170, 250);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(320, 60);
            txtAciklama.TabIndex = 11;
            // 
            // lblGunSayisi
            // 
            lblGunSayisi.AutoSize = true;
            lblGunSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunSayisi.Location = new Point(170, 320);
            lblGunSayisi.Name = "lblGunSayisi";
            lblGunSayisi.Size = new Size(76, 15);
            lblGunSayisi.TabIndex = 12;
            lblGunSayisi.Text = "Gün Sayısı: 1";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(290, 345);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(95, 32);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(395, 345);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(95, 32);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // frm_IzinDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 420);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(lblGunSayisi);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(dtpBitis);
            Controls.Add(lblBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lblBaslangic);
            Controls.Add(cmbDurum);
            Controls.Add(lblDurum);
            Controls.Add(cmbIzinTuru);
            Controls.Add(lblIzinTuru);
            Controls.Add(cmbPersonel);
            Controls.Add(lblPersonel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_IzinDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "İzin Düzenle";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}