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
        private Panel pnlRight;
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
            btnAra = new Button();
            cmbDurumFiltre = new ComboBox();
            lblDurum = new Label();
            cmbIzinTuruFiltre = new ComboBox();
            lblIzinTuru = new Label();
            dtpBitis = new DateTimePicker();
            lblBitis = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBaslangic = new Label();
            cmbPersonelFiltre = new ComboBox();
            lblPersonel = new Label();
            txtArama = new TextBox();
            lblArama = new Label();
            pnlRight = new Panel();
            btnYenile = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnEkle = new Button();
            dgvIzinler = new DataGridView();
            pnlTop.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(28, 30, 38);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(cmbDurumFiltre);
            pnlTop.Controls.Add(lblDurum);
            pnlTop.Controls.Add(cmbIzinTuruFiltre);
            pnlTop.Controls.Add(lblIzinTuru);
            pnlTop.Controls.Add(dtpBitis);
            pnlTop.Controls.Add(lblBitis);
            pnlTop.Controls.Add(dtpBaslangic);
            pnlTop.Controls.Add(lblBaslangic);
            pnlTop.Controls.Add(cmbPersonelFiltre);
            pnlTop.Controls.Add(lblPersonel);
            pnlTop.Controls.Add(txtArama);
            pnlTop.Controls.Add(lblArama);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1384, 108);
            pnlTop.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(380, 62);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(120, 30);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            // 
            // cmbDurumFiltre
            // 
            cmbDurumFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbDurumFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbDurumFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurumFiltre.FlatStyle = FlatStyle.Flat;
            cmbDurumFiltre.Font = new Font("Segoe UI", 10F);
            cmbDurumFiltre.ForeColor = Color.White;
            cmbDurumFiltre.FormattingEnabled = true;
            cmbDurumFiltre.Location = new Point(985, 21);
            cmbDurumFiltre.Name = "cmbDurumFiltre";
            cmbDurumFiltre.Size = new Size(180, 25);
            cmbDurumFiltre.TabIndex = 11;
            // 
            // lblDurum
            // 
            lblDurum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDurum.ForeColor = Color.FromArgb(170, 175, 185);
            lblDurum.Location = new Point(919, 24);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 19);
            lblDurum.TabIndex = 10;
            lblDurum.Text = "Durum";
            // 
            // cmbIzinTuruFiltre
            // 
            cmbIzinTuruFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbIzinTuruFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbIzinTuruFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzinTuruFiltre.FlatStyle = FlatStyle.Flat;
            cmbIzinTuruFiltre.Font = new Font("Segoe UI", 10F);
            cmbIzinTuruFiltre.ForeColor = Color.White;
            cmbIzinTuruFiltre.FormattingEnabled = true;
            cmbIzinTuruFiltre.Location = new Point(699, 21);
            cmbIzinTuruFiltre.Name = "cmbIzinTuruFiltre";
            cmbIzinTuruFiltre.Size = new Size(180, 25);
            cmbIzinTuruFiltre.TabIndex = 9;
            // 
            // lblIzinTuru
            // 
            lblIzinTuru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIzinTuru.AutoSize = true;
            lblIzinTuru.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIzinTuru.ForeColor = Color.FromArgb(170, 175, 185);
            lblIzinTuru.Location = new Point(624, 24);
            lblIzinTuru.Name = "lblIzinTuru";
            lblIzinTuru.Size = new Size(64, 19);
            lblIzinTuru.TabIndex = 8;
            lblIzinTuru.Text = "İzin Türü";
            // 
            // dtpBitis
            // 
            dtpBitis.Font = new Font("Segoe UI", 9.5F);
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(234, 66);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(120, 24);
            dtpBitis.TabIndex = 7;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBitis.ForeColor = Color.FromArgb(170, 175, 185);
            lblBitis.Location = new Point(190, 69);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(37, 19);
            lblBitis.TabIndex = 6;
            lblBitis.Text = "Bitiş";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Font = new Font("Segoe UI", 9.5F);
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(80, 66);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(100, 24);
            dtpBaslangic.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBaslangic.ForeColor = Color.FromArgb(170, 175, 185);
            lblBaslangic.Location = new Point(24, 69);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(42, 19);
            lblBaslangic.TabIndex = 4;
            lblBaslangic.Text = "Tarih";
            // 
            // cmbPersonelFiltre
            // 
            cmbPersonelFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPersonelFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbPersonelFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelFiltre.FlatStyle = FlatStyle.Flat;
            cmbPersonelFiltre.Font = new Font("Segoe UI", 10F);
            cmbPersonelFiltre.ForeColor = Color.White;
            cmbPersonelFiltre.FormattingEnabled = true;
            cmbPersonelFiltre.Location = new Point(430, 21);
            cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            cmbPersonelFiltre.Size = new Size(180, 25);
            cmbPersonelFiltre.TabIndex = 3;
            // 
            // lblPersonel
            // 
            lblPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPersonel.ForeColor = Color.FromArgb(170, 175, 185);
            lblPersonel.Location = new Point(350, 24);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(67, 19);
            lblPersonel.TabIndex = 2;
            lblPersonel.Text = "Personel";
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(35, 38, 45);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.Font = new Font("Segoe UI", 10F);
            txtArama.ForeColor = Color.White;
            txtArama.Location = new Point(90, 21);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "İzin türü veya açıklama ara...";
            txtArama.Size = new Size(250, 25);
            txtArama.TabIndex = 1;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblArama.ForeColor = Color.FromArgb(170, 175, 185);
            lblArama.Location = new Point(24, 24);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(54, 19);
            lblArama.TabIndex = 0;
            lblArama.Text = "Arama";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(24, 26, 33);
            pnlRight.Controls.Add(btnYenile);
            pnlRight.Controls.Add(btnSil);
            pnlRight.Controls.Add(btnDuzenle);
            pnlRight.Controls.Add(btnEkle);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(1204, 108);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(180, 613);
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
            btnEkle.Text = "Yeni İzin";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // dgvIzinler
            // 
            dgvIzinler.AllowUserToAddRows = false;
            dgvIzinler.AllowUserToDeleteRows = false;
            dgvIzinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIzinler.BackgroundColor = Color.FromArgb(20, 22, 27);
            dgvIzinler.BorderStyle = BorderStyle.None;
            dgvIzinler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvIzinler.EnableHeadersVisualStyles = false;
            dgvIzinler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 38, 45);
            dgvIzinler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIzinler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvIzinler.DefaultCellStyle.BackColor = Color.FromArgb(28, 30, 38);
            dgvIzinler.DefaultCellStyle.ForeColor = Color.FromArgb(220, 230, 242);
            dgvIzinler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvIzinler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvIzinler.GridColor = Color.FromArgb(45, 48, 55);
            dgvIzinler.RowHeadersVisible = false;

            dgvIzinler.Dock = DockStyle.Fill;
            dgvIzinler.Location = new Point(0, 108);
            dgvIzinler.MultiSelect = false;
            dgvIzinler.Name = "dgvIzinler";
            dgvIzinler.ReadOnly = true;
            dgvIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinler.Size = new Size(1204, 613);
            dgvIzinler.TabIndex = 2;
            // 
            // frm_IzinYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1384, 721);
            Controls.Add(dgvIzinler);
            Controls.Add(pnlRight);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 700);
            Name = "frm_IzinYonetimi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "İzin Yönetimi";
            Load += frm_IzinYonetimi_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).EndInit();
            ResumeLayout(false);
        }
    }
}