    namespace MiniPersonelTakip
{
    partial class frm_PersonelTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonelTakip));
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
            pnlTop.BackColor = Color.WhiteSmoke;
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
            cmbPozisyonFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyonFiltre.Font = new Font("Segoe UI", 10F);
            cmbPozisyonFiltre.FormattingEnabled = true;
            cmbPozisyonFiltre.Location = new Point(1083, 27);
            cmbPozisyonFiltre.Name = "cmbPozisyonFiltre";
            cmbPozisyonFiltre.Size = new Size(160, 25);
            cmbPozisyonFiltre.TabIndex = 7;
            cmbPozisyonFiltre.SelectedIndexChanged += cmbPozisyonFiltre_SelectedIndexChanged;
            // 
            // lblPozisyonFiltre
            // 
            lblPozisyonFiltre.AutoSize = true;
            lblPozisyonFiltre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPozisyonFiltre.Location = new Point(1010, 31);
            lblPozisyonFiltre.Name = "lblPozisyonFiltre";
            lblPozisyonFiltre.Size = new Size(69, 19);
            lblPozisyonFiltre.TabIndex = 6;
            lblPozisyonFiltre.Text = "Pozisyon";
            // 
            // cmbDepartmanFiltre
            // 
            cmbDepartmanFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartmanFiltre.Font = new Font("Segoe UI", 10F);
            cmbDepartmanFiltre.FormattingEnabled = true;
            cmbDepartmanFiltre.Location = new Point(824, 27);
            cmbDepartmanFiltre.Name = "cmbDepartmanFiltre";
            cmbDepartmanFiltre.Size = new Size(160, 25);
            cmbDepartmanFiltre.TabIndex = 5;
            cmbDepartmanFiltre.SelectedIndexChanged += cmbDepartmanFiltre_SelectedIndexChanged;
            // 
            // lblDepartmanFiltre
            // 
            lblDepartmanFiltre.AutoSize = true;
            lblDepartmanFiltre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            btnAra.Size = new Size(110, 32);
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
            txtArama.Font = new Font("Segoe UI", 10F);
            txtArama.Location = new Point(94, 28);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Ad, soyad, personel kodu, telefon, e-posta...";
            txtArama.Size = new Size(321, 25);
            txtArama.TabIndex = 1;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblArama.Location = new Point(24, 31);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(54, 19);
            lblArama.TabIndex = 0;
            lblArama.Text = "Arama";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.WhiteSmoke;
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
            btnYenile.BackColor = Color.FromArgb(52, 73, 94);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(18, 212);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(144, 40);
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
            btnSil.Size = new Size(144, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Pasife Al";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(243, 156, 18);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(18, 102);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(144, 40);
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
            btnEkle.Size = new Size(144, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Yeni Personel";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
            dgvPersoneller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.BackgroundColor = Color.White;
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Location = new Point(24, 96);
            dgvPersoneller.MultiSelect = false;
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersWidth = 51;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(1052, 599);
            dgvPersoneller.TabIndex = 2;
            dgvPersoneller.CellDoubleClick += dgvPersoneller_CellDoubleClick;
            // 
            // frm_PersonelTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 721);
            Controls.Add(dgvPersoneller);
            Controls.Add(pnlRight);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 700);
            Name = "frm_PersonelTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Yönetimi";
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