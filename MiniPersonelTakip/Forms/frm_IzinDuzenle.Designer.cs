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
            // lblIzinTuru
            // 
            lblIzinTuru.AutoSize = true;
            lblIzinTuru.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIzinTuru.ForeColor = Color.FromArgb(170, 175, 185);
            lblIzinTuru.Location = new Point(32, 92);
            lblIzinTuru.Name = "lblIzinTuru";
            lblIzinTuru.Size = new Size(65, 19);
            lblIzinTuru.TabIndex = 2;
            lblIzinTuru.Text = "İzin Türü";
            // 
            // cmbIzinTuru
            // 
            cmbIzinTuru.BackColor = Color.FromArgb(35, 38, 45);
            cmbIzinTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzinTuru.FlatStyle = FlatStyle.Flat;
            cmbIzinTuru.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbIzinTuru.ForeColor = Color.White;
            cmbIzinTuru.FormattingEnabled = true;
            cmbIzinTuru.Location = new Point(32, 114);
            cmbIzinTuru.Name = "cmbIzinTuru";
            cmbIzinTuru.Size = new Size(330, 25);
            cmbIzinTuru.TabIndex = 3;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = Color.FromArgb(170, 175, 185);
            lblDurum.Location = new Point(398, 92);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 4;
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
            cmbDurum.Location = new Point(398, 114);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(330, 25);
            cmbDurum.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslangic.ForeColor = Color.FromArgb(170, 175, 185);
            lblBaslangic.Location = new Point(32, 156);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(113, 19);
            lblBaslangic.TabIndex = 6;
            lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(32, 178);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(160, 24);
            dtpBaslangic.TabIndex = 7;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBitis.ForeColor = Color.FromArgb(170, 175, 185);
            lblBitis.Location = new Point(214, 156);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(78, 19);
            lblBitis.TabIndex = 8;
            lblBitis.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(214, 178);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(160, 24);
            dtpBitis.TabIndex = 9;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.FromArgb(170, 175, 185);
            lblAciklama.Location = new Point(32, 224);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(71, 19);
            lblAciklama.TabIndex = 10;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAciklama.BackColor = Color.FromArgb(35, 38, 45);
            txtAciklama.BorderStyle = BorderStyle.FixedSingle;
            txtAciklama.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAciklama.ForeColor = Color.White;
            txtAciklama.Location = new Point(32, 246);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Size = new Size(696, 84);
            txtAciklama.TabIndex = 11;
            // 
            // lblGunSayisi
            // 
            lblGunSayisi.AutoSize = true;
            lblGunSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunSayisi.ForeColor = Color.FromArgb(170, 175, 185);
            lblGunSayisi.Location = new Point(32, 345);
            lblGunSayisi.Name = "lblGunSayisi";
            lblGunSayisi.Size = new Size(93, 19);
            lblGunSayisi.TabIndex = 12;
            lblGunSayisi.Text = "Gün Sayısı: 1";
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(542, 385);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 36);
            btnKaydet.TabIndex = 13;
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
            btnIptal.Location = new Point(638, 385);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(90, 36);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // frm_IzinDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(760, 445);
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
            MinimumSize = new Size(776, 484);
            Name = "frm_IzinDuzenle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "İzin Düzenle";
            Load += frm_IzinDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}