namespace MiniPersonelTakip.Forms
{
    partial class frm_GorevYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Label lblArama;
        private TextBox txtArama;
        private Label lblPersonel;
        private ComboBox cmbPersonelFiltre;
        private Label lblOncelik;
        private ComboBox cmbOncelikFiltre;
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
        private DataGridView dgvGorevler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GorevYonetimi));
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
            cmbOncelikFiltre = new ComboBox();
            lblOncelik = new Label();
            cmbPersonelFiltre = new ComboBox();
            lblPersonel = new Label();
            txtArama = new TextBox();
            lblArama = new Label();
            dgvGorevler = new DataGridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGorevler).BeginInit();
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
            pnlTop.Controls.Add(cmbOncelikFiltre);
            pnlTop.Controls.Add(lblOncelik);
            pnlTop.Controls.Add(cmbPersonelFiltre);
            pnlTop.Controls.Add(lblPersonel);
            pnlTop.Controls.Add(txtArama);
            pnlTop.Controls.Add(lblArama);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1184, 130);
            pnlTop.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(800, 48);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 27);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(710, 48);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(80, 27);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(620, 48);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(80, 27);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(530, 48);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(80, 27);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(440, 48);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 27);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(290, 50);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(120, 23);
            dtpBitis.TabIndex = 5;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(240, 55);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(29, 15);
            lblBitis.TabIndex = 6;
            lblBitis.Text = "Bitiş";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(100, 50);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(120, 23);
            dtpBaslangic.TabIndex = 7;
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
            cmbDurumFiltre.TabIndex = 9;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(860, 15);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 15);
            lblDurum.TabIndex = 10;
            lblDurum.Text = "Durum";
            // 
            // cmbOncelikFiltre
            // 
            cmbOncelikFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOncelikFiltre.FormattingEnabled = true;
            cmbOncelikFiltre.Location = new Point(690, 10);
            cmbOncelikFiltre.Name = "cmbOncelikFiltre";
            cmbOncelikFiltre.Size = new Size(150, 23);
            cmbOncelikFiltre.TabIndex = 11;
            // 
            // lblOncelik
            // 
            lblOncelik.AutoSize = true;
            lblOncelik.Location = new Point(610, 15);
            lblOncelik.Name = "lblOncelik";
            lblOncelik.Size = new Size(47, 15);
            lblOncelik.TabIndex = 12;
            lblOncelik.Text = "Öncelik";
            // 
            // cmbPersonelFiltre
            // 
            cmbPersonelFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelFiltre.FormattingEnabled = true;
            cmbPersonelFiltre.Location = new Point(370, 10);
            cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            cmbPersonelFiltre.Size = new Size(220, 23);
            cmbPersonelFiltre.TabIndex = 13;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Location = new Point(300, 15);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(52, 15);
            lblPersonel.TabIndex = 14;
            lblPersonel.Text = "Personel";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(100, 10);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(180, 23);
            txtArama.TabIndex = 15;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new Point(15, 15);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(42, 15);
            lblArama.TabIndex = 16;
            lblArama.Text = "Arama";
            // 
            // dgvGorevler
            // 
            dgvGorevler.AllowUserToAddRows = false;
            dgvGorevler.AllowUserToDeleteRows = false;
            dgvGorevler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGorevler.Dock = DockStyle.Fill;
            dgvGorevler.Location = new Point(0, 130);
            dgvGorevler.MultiSelect = false;
            dgvGorevler.Name = "dgvGorevler";
            dgvGorevler.ReadOnly = true;
            dgvGorevler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGorevler.Size = new Size(1184, 531);
            dgvGorevler.TabIndex = 0;
            // 
            // frm_GorevYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(dgvGorevler);
            Controls.Add(pnlTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_GorevYonetimi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Görev Yönetimi";
            WindowState = FormWindowState.Maximized;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGorevler).EndInit();
            ResumeLayout(false);
        }
    }
}