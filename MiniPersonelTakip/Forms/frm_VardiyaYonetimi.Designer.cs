namespace MiniPersonelTakip
{
    partial class frm_VardiyaYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VardiyaYonetimi));
            pnlTop = new Panel();
            btnAra = new Button();
            cmbDurumFiltre = new ComboBox();
            lblDurum = new Label();
            cmbVardiyaTipiFiltre = new ComboBox();
            lblVardiyaTipi = new Label();
            dtpBitisTarihi = new DateTimePicker();
            lblBitis = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            lblBaslangic = new Label();
            cmbPersonelFiltre = new ComboBox();
            lblPersonel = new Label();
            pnlRight = new Panel();
            btnYenile = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnEkle = new Button();
            dgvVardiyalar = new DataGridView();
            pnlTop.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVardiyalar).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(28, 30, 38);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(cmbDurumFiltre);
            pnlTop.Controls.Add(lblDurum);
            pnlTop.Controls.Add(cmbVardiyaTipiFiltre);
            pnlTop.Controls.Add(lblVardiyaTipi);
            pnlTop.Controls.Add(dtpBitisTarihi);
            pnlTop.Controls.Add(lblBitis);
            pnlTop.Controls.Add(dtpBaslangicTarihi);
            pnlTop.Controls.Add(lblBaslangic);
            pnlTop.Controls.Add(cmbPersonelFiltre);
            pnlTop.Controls.Add(lblPersonel);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1384, 88);
            pnlTop.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(1210, 28);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(120, 30);
            btnAra.TabIndex = 10;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // cmbDurumFiltre
            // 
            cmbDurumFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbDurumFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurumFiltre.FlatStyle = FlatStyle.Flat;
            cmbDurumFiltre.Font = new Font("Segoe UI", 10F);
            cmbDurumFiltre.ForeColor = Color.White;
            cmbDurumFiltre.FormattingEnabled = true;
            cmbDurumFiltre.Location = new Point(1012, 31);
            cmbDurumFiltre.Name = "cmbDurumFiltre";
            cmbDurumFiltre.Size = new Size(176, 25);
            cmbDurumFiltre.TabIndex = 9;
            cmbDurumFiltre.SelectedIndexChanged += cmbDurumFiltre_SelectedIndexChanged;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDurum.ForeColor = Color.FromArgb(170, 175, 185);
            lblDurum.Location = new Point(946, 34);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 8;
            lblDurum.Text = "Durum";
            // 
            // cmbVardiyaTipiFiltre
            // 
            cmbVardiyaTipiFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbVardiyaTipiFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVardiyaTipiFiltre.FlatStyle = FlatStyle.Flat;
            cmbVardiyaTipiFiltre.Font = new Font("Segoe UI", 10F);
            cmbVardiyaTipiFiltre.ForeColor = Color.White;
            cmbVardiyaTipiFiltre.FormattingEnabled = true;
            cmbVardiyaTipiFiltre.Location = new Point(744, 31);
            cmbVardiyaTipiFiltre.Name = "cmbVardiyaTipiFiltre";
            cmbVardiyaTipiFiltre.Size = new Size(176, 25);
            cmbVardiyaTipiFiltre.TabIndex = 7;
            cmbVardiyaTipiFiltre.SelectedIndexChanged += cmbVardiyaTipiFiltre_SelectedIndexChanged;
            // 
            // lblVardiyaTipi
            // 
            lblVardiyaTipi.AutoSize = true;
            lblVardiyaTipi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVardiyaTipi.ForeColor = Color.FromArgb(170, 175, 185);
            lblVardiyaTipi.Location = new Point(647, 34);
            lblVardiyaTipi.Name = "lblVardiyaTipi";
            lblVardiyaTipi.Size = new Size(89, 19);
            lblVardiyaTipi.TabIndex = 6;
            lblVardiyaTipi.Text = "Vardiya Tipi";
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Font = new Font("Segoe UI", 9.5F);
            dtpBitisTarihi.Format = DateTimePickerFormat.Short;
            dtpBitisTarihi.Location = new Point(520, 31);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(110, 24);
            dtpBitisTarihi.TabIndex = 5;
            dtpBitisTarihi.ValueChanged += dtpBitisTarihi_ValueChanged;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBitis.ForeColor = Color.FromArgb(170, 175, 185);
            lblBitis.Location = new Point(480, 34);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(37, 19);
            lblBitis.TabIndex = 4;
            lblBitis.Text = "Bitiş";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Font = new Font("Segoe UI", 9.5F);
            dtpBaslangicTarihi.Format = DateTimePickerFormat.Short;
            dtpBaslangicTarihi.Location = new Point(352, 31);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(110, 24);
            dtpBaslangicTarihi.TabIndex = 3;
            dtpBaslangicTarihi.ValueChanged += dtpBaslangicTarihi_ValueChanged;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBaslangic.ForeColor = Color.FromArgb(170, 175, 185);
            lblBaslangic.Location = new Point(274, 34);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(72, 19);
            lblBaslangic.TabIndex = 2;
            lblBaslangic.Text = "Başlangıç";
            // 
            // cmbPersonelFiltre
            // 
            cmbPersonelFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbPersonelFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelFiltre.FlatStyle = FlatStyle.Flat;
            cmbPersonelFiltre.Font = new Font("Segoe UI", 10F);
            cmbPersonelFiltre.ForeColor = Color.White;
            cmbPersonelFiltre.FormattingEnabled = true;
            cmbPersonelFiltre.Location = new Point(91, 31);
            cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            cmbPersonelFiltre.Size = new Size(168, 25);
            cmbPersonelFiltre.TabIndex = 1;
            cmbPersonelFiltre.SelectedIndexChanged += cmbPersonelFiltre_SelectedIndexChanged;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPersonel.ForeColor = Color.FromArgb(170, 175, 185);
            lblPersonel.Location = new Point(24, 34);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(67, 19);
            lblPersonel.TabIndex = 0;
            lblPersonel.Text = "Personel";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(24, 26, 33);
            pnlRight.Controls.Add(btnYenile);
            pnlRight.Controls.Add(btnSil);
            pnlRight.Controls.Add(btnDuzenle);
            pnlRight.Controls.Add(btnEkle);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(1204, 88);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(180, 633);
            pnlRight.TabIndex = 1;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(44, 62, 80);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(20, 193);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(140, 45);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(231, 76, 60);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(20, 139);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 45);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(220, 160, 30);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(20, 85);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(140, 45);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(46, 204, 113);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(20, 31);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 45);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Yeni Vardiya";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvVardiyalar
            // 
            dgvVardiyalar.AllowUserToAddRows = false;
            dgvVardiyalar.AllowUserToDeleteRows = false;
            dgvVardiyalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVardiyalar.BackgroundColor = Color.FromArgb(20, 22, 27);
            dgvVardiyalar.BorderStyle = BorderStyle.None;
            dgvVardiyalar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Özel Header Tasarımı (Dark Mode İçin Kritik)
            dgvVardiyalar.EnableHeadersVisualStyles = false;
            dgvVardiyalar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 38, 45);
            dgvVardiyalar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVardiyalar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvVardiyalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Satır Tasarımı
            dgvVardiyalar.DefaultCellStyle.BackColor = Color.FromArgb(28, 30, 38);
            dgvVardiyalar.DefaultCellStyle.ForeColor = Color.FromArgb(220, 230, 242);
            dgvVardiyalar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvVardiyalar.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVardiyalar.GridColor = Color.FromArgb(45, 48, 55);
            dgvVardiyalar.RowHeadersVisible = false;

            dgvVardiyalar.Dock = DockStyle.Fill;
            dgvVardiyalar.Location = new Point(0, 88);
            dgvVardiyalar.MultiSelect = false;
            dgvVardiyalar.Name = "dgvVardiyalar";
            dgvVardiyalar.ReadOnly = true;
            dgvVardiyalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVardiyalar.Size = new Size(1204, 633);
            dgvVardiyalar.TabIndex = 2;
            dgvVardiyalar.CellDoubleClick += dgvVardiyalar_CellDoubleClick;
            // 
            // frm_VardiyaYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1384, 721);
            Controls.Add(dgvVardiyalar);
            Controls.Add(pnlRight);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 700);
            Name = "frm_VardiyaYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vardiya Yönetimi";
            Load += frm_VardiyaYonetimi_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVardiyalar).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private Button btnAra;
        private ComboBox cmbDurumFiltre;
        private Label lblDurum;
        private ComboBox cmbVardiyaTipiFiltre;
        private Label lblVardiyaTipi;
        private DateTimePicker dtpBitisTarihi;
        private Label lblBitis;
        private DateTimePicker dtpBaslangicTarihi;
        private Label lblBaslangic;
        private ComboBox cmbPersonelFiltre;
        private Label lblPersonel;
        private Panel pnlRight;
        private Button btnYenile;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnEkle;
        private DataGridView dgvVardiyalar;
    }
}