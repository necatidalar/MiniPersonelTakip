namespace MiniPersonelTakip
{
    partial class frm_PersonelYonetimi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonelYonetimi));
            pnlTop = new Panel();
            cmbPozisyonFiltre = new ComboBox();
            lblPozisyonFiltre = new Label();
            cmbDepartmanFiltre = new ComboBox();
            lblDepartmanFiltre = new Label();
            btnAra = new Button();
            chkSadeceAktifler = new CheckBox();
            txtArama = new TextBox();
            lblArama = new Label();
            pnlRight = new Panel();
            btnYenile = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnEkle = new Button();
            dgvPersoneller = new DataGridView();
            pnlTop.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(28, 30, 38);
            pnlTop.Controls.Add(cmbPozisyonFiltre);
            pnlTop.Controls.Add(lblPozisyonFiltre);
            pnlTop.Controls.Add(cmbDepartmanFiltre);
            pnlTop.Controls.Add(lblDepartmanFiltre);
            pnlTop.Controls.Add(btnAra);
            pnlTop.Controls.Add(chkSadeceAktifler);
            pnlTop.Controls.Add(txtArama);
            pnlTop.Controls.Add(lblArama);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1280, 74);
            pnlTop.TabIndex = 0;
            // 
            // cmbPozisyonFiltre
            // 
            cmbPozisyonFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPozisyonFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbPozisyonFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyonFiltre.FlatStyle = FlatStyle.Flat;
            cmbPozisyonFiltre.Font = new Font("Segoe UI", 10F);
            cmbPozisyonFiltre.ForeColor = Color.White;
            cmbPozisyonFiltre.FormattingEnabled = true;
            cmbPozisyonFiltre.Location = new Point(1083, 27);
            cmbPozisyonFiltre.Name = "cmbPozisyonFiltre";
            cmbPozisyonFiltre.Size = new Size(160, 25);
            cmbPozisyonFiltre.TabIndex = 7;
            cmbPozisyonFiltre.SelectedIndexChanged += cmbPozisyonFiltre_SelectedIndexChanged;
            // 
            // lblPozisyonFiltre
            // 
            lblPozisyonFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPozisyonFiltre.AutoSize = true;
            lblPozisyonFiltre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPozisyonFiltre.ForeColor = Color.FromArgb(170, 175, 185);
            lblPozisyonFiltre.Location = new Point(1010, 31);
            lblPozisyonFiltre.Name = "lblPozisyonFiltre";
            lblPozisyonFiltre.Size = new Size(69, 19);
            lblPozisyonFiltre.TabIndex = 6;
            lblPozisyonFiltre.Text = "Pozisyon";
            // 
            // cmbDepartmanFiltre
            // 
            cmbDepartmanFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbDepartmanFiltre.BackColor = Color.FromArgb(35, 38, 45);
            cmbDepartmanFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartmanFiltre.FlatStyle = FlatStyle.Flat;
            cmbDepartmanFiltre.Font = new Font("Segoe UI", 10F);
            cmbDepartmanFiltre.ForeColor = Color.White;
            cmbDepartmanFiltre.FormattingEnabled = true;
            cmbDepartmanFiltre.Location = new Point(824, 27);
            cmbDepartmanFiltre.Name = "cmbDepartmanFiltre";
            cmbDepartmanFiltre.Size = new Size(160, 25);
            cmbDepartmanFiltre.TabIndex = 5;
            cmbDepartmanFiltre.SelectedIndexChanged += cmbDepartmanFiltre_SelectedIndexChanged;
            // 
            // lblDepartmanFiltre
            // 
            lblDepartmanFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDepartmanFiltre.AutoSize = true;
            lblDepartmanFiltre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDepartmanFiltre.ForeColor = Color.FromArgb(170, 175, 185);
            lblDepartmanFiltre.Location = new Point(735, 31);
            lblDepartmanFiltre.Name = "lblDepartmanFiltre";
            lblDepartmanFiltre.Size = new Size(84, 19);
            lblDepartmanFiltre.TabIndex = 4;
            lblDepartmanFiltre.Text = "Departman";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(433, 25);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(110, 30);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // chkSadeceAktifler
            // 
            chkSadeceAktifler.AutoSize = true;
            chkSadeceAktifler.Checked = true;
            chkSadeceAktifler.CheckState = CheckState.Checked;
            chkSadeceAktifler.Font = new Font("Segoe UI", 10F);
            chkSadeceAktifler.ForeColor = Color.FromArgb(170, 175, 185);
            chkSadeceAktifler.Location = new Point(570, 30);
            chkSadeceAktifler.Name = "chkSadeceAktifler";
            chkSadeceAktifler.Size = new Size(117, 23);
            chkSadeceAktifler.TabIndex = 2;
            chkSadeceAktifler.Text = "Sadece Aktifler";
            chkSadeceAktifler.UseVisualStyleBackColor = true;
            chkSadeceAktifler.CheckedChanged += chkSadeceAktifler_CheckedChanged;
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(35, 38, 45);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.Font = new Font("Segoe UI", 10F);
            txtArama.ForeColor = Color.White;
            txtArama.Location = new Point(94, 28);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Ad, soyad, personel kodu...";
            txtArama.Size = new Size(321, 25);
            txtArama.TabIndex = 1;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblArama.ForeColor = Color.FromArgb(170, 175, 185);
            lblArama.Location = new Point(24, 31);
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
            pnlRight.Location = new Point(1100, 74);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(180, 647);
            pnlRight.TabIndex = 1;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(44, 62, 80);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(18, 212);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(144, 45);
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
            btnSil.Location = new Point(18, 157);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(144, 45);
            btnSil.TabIndex = 2;
            btnSil.Text = "Pasife Al";
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
            btnDuzenle.Location = new Point(18, 102);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(144, 45);
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
            btnEkle.Location = new Point(18, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(144, 45);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Yeni Personel";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.BackgroundColor = Color.FromArgb(20, 22, 27);
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 38, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 30, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(220, 230, 242);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersoneller.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersoneller.Dock = DockStyle.Fill;
            dgvPersoneller.EnableHeadersVisualStyles = false;
            dgvPersoneller.GridColor = Color.FromArgb(45, 48, 55);
            dgvPersoneller.Location = new Point(0, 74);
            dgvPersoneller.MultiSelect = false;
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersVisible = false;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(1100, 647);
            dgvPersoneller.TabIndex = 2;
            dgvPersoneller.CellDoubleClick += dgvPersoneller_CellDoubleClick;
            // 
            // frm_PersonelYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1280, 721);
            Controls.Add(dgvPersoneller);
            Controls.Add(pnlRight);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 700);
            Name = "frm_PersonelYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Yönetimi";
            WindowState = FormWindowState.Maximized;
            Load += frm_MiniPersonelTakip_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private ComboBox cmbPozisyonFiltre;
        private Label lblPozisyonFiltre;
        private ComboBox cmbDepartmanFiltre;
        private Label lblDepartmanFiltre;
        private Button btnAra;
        private CheckBox chkSadeceAktifler;
        private TextBox txtArama;
        private Label lblArama;
        private Panel pnlRight;
        private Button btnYenile;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnEkle;
        private DataGridView dgvPersoneller;
    }
}