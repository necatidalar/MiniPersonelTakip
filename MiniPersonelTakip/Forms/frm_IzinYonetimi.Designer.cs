namespace MiniPersonelTakip.Forms
{
    partial class frm_IzinYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Label lblArama;
        private TextBox txtArama;
        private Label lblPersonel;
        private ComboBox cmbPersonelFiltre;
        private Label lblIzinTuru;
        private ComboBox cmbIzinTuruFiltre;
        private Label lblDurum;
        private ComboBox cmbDurumFiltre;
        private Label lblBaslangic;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private DateTimePicker dtpBitis;
        private Button btnAra;
        private Button btnYenile;
        private Button btnEkle;
        private Button btnDuzenle;
        private Button btnSil;
        private DataGridView dgvIzinler;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IzinYonetimi));
            pnlTop = new Panel();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnEkle = new Button();
            btnYenile = new Button();
            btnAra = new Button();
            dtpBitis = new DateTimePicker();
            lblBitis = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBaslangic = new Label();
            cmbDurumFiltre = new ComboBox();
            lblDurum = new Label();
            cmbIzinTuruFiltre = new ComboBox();
            lblIzinTuru = new Label();
            cmbPersonelFiltre = new ComboBox();
            lblPersonel = new Label();
            txtArama = new TextBox();
            lblArama = new Label();
            dgvIzinler = new DataGridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnSil);
            pnlTop.Controls.Add(btnDuzenle);
            pnlTop.Controls.Add(btnEkle);
            pnlTop.Controls.Add(btnYenile);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(dtpBitis);
            pnlTop.Controls.Add(lblBitis);
            pnlTop.Controls.Add(dtpBaslangic);
            pnlTop.Controls.Add(lblBaslangic);
            pnlTop.Controls.Add(cmbDurumFiltre);
            pnlTop.Controls.Add(lblDurum);
            pnlTop.Controls.Add(cmbIzinTuruFiltre);
            pnlTop.Controls.Add(lblIzinTuru);
            pnlTop.Controls.Add(cmbPersonelFiltre);
            pnlTop.Controls.Add(lblPersonel);
            pnlTop.Controls.Add(txtArama);
            pnlTop.Controls.Add(lblArama);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1184, 130);
            pnlTop.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(800, 48);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 27);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(710, 48);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(80, 27);
            btnDuzenle.TabIndex = 15;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(620, 48);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(80, 27);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(530, 48);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(80, 27);
            btnYenile.TabIndex = 13;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(440, 48);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 27);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(290, 50);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(120, 23);
            dtpBitis.TabIndex = 11;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(240, 55);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(29, 15);
            lblBitis.TabIndex = 10;
            lblBitis.Text = "Bitiş";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(100, 50);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(120, 23);
            dtpBaslangic.TabIndex = 9;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(15, 55);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(57, 15);
            lblBaslangic.TabIndex = 8;
            lblBaslangic.Text = "Başlangıç";
            // 
            // cmbDurumFiltre
            // 
            cmbDurumFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurumFiltre.FormattingEnabled = true;
            cmbDurumFiltre.Location = new Point(920, 10);
            cmbDurumFiltre.Name = "cmbDurumFiltre";
            cmbDurumFiltre.Size = new Size(140, 23);
            cmbDurumFiltre.TabIndex = 7;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(860, 15);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 15);
            lblDurum.TabIndex = 6;
            lblDurum.Text = "Durum";
            // 
            // cmbIzinTuruFiltre
            // 
            cmbIzinTuruFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzinTuruFiltre.FormattingEnabled = true;
            cmbIzinTuruFiltre.Location = new Point(690, 10);
            cmbIzinTuruFiltre.Name = "cmbIzinTuruFiltre";
            cmbIzinTuruFiltre.Size = new Size(150, 23);
            cmbIzinTuruFiltre.TabIndex = 5;
            // 
            // lblIzinTuru
            // 
            lblIzinTuru.AutoSize = true;
            lblIzinTuru.Location = new Point(610, 15);
            lblIzinTuru.Name = "lblIzinTuru";
            lblIzinTuru.Size = new Size(52, 15);
            lblIzinTuru.TabIndex = 4;
            lblIzinTuru.Text = "İzin Türü";
            // 
            // cmbPersonelFiltre
            // 
            cmbPersonelFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelFiltre.FormattingEnabled = true;
            cmbPersonelFiltre.Location = new Point(370, 10);
            cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            cmbPersonelFiltre.Size = new Size(220, 23);
            cmbPersonelFiltre.TabIndex = 3;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Location = new Point(300, 15);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(52, 15);
            lblPersonel.TabIndex = 2;
            lblPersonel.Text = "Personel";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(100, 10);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(180, 23);
            txtArama.TabIndex = 1;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new Point(15, 15);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(42, 15);
            lblArama.TabIndex = 0;
            lblArama.Text = "Arama";
            // 
            // dgvIzinler
            // 
            dgvIzinler.AllowUserToAddRows = false;
            dgvIzinler.AllowUserToDeleteRows = false;
            dgvIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIzinler.Dock = DockStyle.Fill;
            dgvIzinler.Location = new Point(0, 130);
            dgvIzinler.MultiSelect = false;
            dgvIzinler.Name = "dgvIzinler";
            dgvIzinler.ReadOnly = true;
            dgvIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinler.Size = new Size(1184, 531);
            dgvIzinler.TabIndex = 1;
            // 
            // frm_IzinYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(dgvIzinler);
            Controls.Add(pnlTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_IzinYonetimi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "İzin Yönetimi";
            WindowState = FormWindowState.Maximized;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).EndInit();
            ResumeLayout(false);
        }
    }
}