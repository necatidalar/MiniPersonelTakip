namespace MiniPersonelTakip
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlTop = new Panel();
            lblAltBaslik = new Label();
            lblBaslik = new Label();
            pnlSidebar = new Panel();
            btnGorevYonetimi = new Button();
            btnIzinYonetimi = new Button();
            btnVardiyaYonetimi = new Button();
            btnPersonelYonetimi = new Button();
            pnlMenuTop = new Panel();
            lblMenu = new Label();
            pnlBottom = new Panel();
            lblDurum = new Label();
            pnlTop.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMenuTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(24, 44, 97);
            pnlTop.Controls.Add(lblAltBaslik);
            pnlTop.Controls.Add(lblBaslik);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(260, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(940, 90);
            pnlTop.TabIndex = 0;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAltBaslik.ForeColor = Color.FromArgb(220, 230, 242);
            lblAltBaslik.Location = new Point(28, 50);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(232, 19);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Personel, izin, vardiya ve görev takibi";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(24, 12);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(268, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Mini Personel Takip";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(245, 247, 250);
            pnlSidebar.Controls.Add(btnGorevYonetimi);
            pnlSidebar.Controls.Add(btnIzinYonetimi);
            pnlSidebar.Controls.Add(btnVardiyaYonetimi);
            pnlSidebar.Controls.Add(btnPersonelYonetimi);
            pnlSidebar.Controls.Add(pnlMenuTop);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 700);
            pnlSidebar.TabIndex = 1;
            // 
            // btnGorevYonetimi
            // 
            btnGorevYonetimi.BackColor = Color.FromArgb(241, 196, 15);
            btnGorevYonetimi.FlatAppearance.BorderSize = 0;
            btnGorevYonetimi.FlatStyle = FlatStyle.Flat;
            btnGorevYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGorevYonetimi.ForeColor = Color.White;
            btnGorevYonetimi.Location = new Point(20, 300);
            btnGorevYonetimi.Name = "btnGorevYonetimi";
            btnGorevYonetimi.Size = new Size(220, 52);
            btnGorevYonetimi.TabIndex = 4;
            btnGorevYonetimi.Text = "Görev Yönetimi";
            btnGorevYonetimi.UseVisualStyleBackColor = false;
            btnGorevYonetimi.Click += btnGorevYonetimi_Click;
            // 
            // btnIzinYonetimi
            // 
            btnIzinYonetimi.BackColor = Color.FromArgb(155, 89, 182);
            btnIzinYonetimi.FlatAppearance.BorderSize = 0;
            btnIzinYonetimi.FlatStyle = FlatStyle.Flat;
            btnIzinYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIzinYonetimi.ForeColor = Color.White;
            btnIzinYonetimi.Location = new Point(20, 236);
            btnIzinYonetimi.Name = "btnIzinYonetimi";
            btnIzinYonetimi.Size = new Size(220, 52);
            btnIzinYonetimi.TabIndex = 3;
            btnIzinYonetimi.Text = "İzin Yönetimi";
            btnIzinYonetimi.UseVisualStyleBackColor = false;
            btnIzinYonetimi.Click += btnIzinYonetimi_Click;
            // 
            // btnVardiyaYonetimi
            // 
            btnVardiyaYonetimi.BackColor = Color.FromArgb(46, 204, 113);
            btnVardiyaYonetimi.FlatAppearance.BorderSize = 0;
            btnVardiyaYonetimi.FlatStyle = FlatStyle.Flat;
            btnVardiyaYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnVardiyaYonetimi.ForeColor = Color.White;
            btnVardiyaYonetimi.Location = new Point(20, 172);
            btnVardiyaYonetimi.Name = "btnVardiyaYonetimi";
            btnVardiyaYonetimi.Size = new Size(220, 52);
            btnVardiyaYonetimi.TabIndex = 2;
            btnVardiyaYonetimi.Text = "Vardiya Yönetimi";
            btnVardiyaYonetimi.UseVisualStyleBackColor = false;
            btnVardiyaYonetimi.Click += btnVardiyaYonetimi_Click;
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.BackColor = Color.FromArgb(52, 152, 219);
            btnPersonelYonetimi.FlatAppearance.BorderSize = 0;
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonelYonetimi.ForeColor = Color.White;
            btnPersonelYonetimi.Location = new Point(20, 108);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(220, 52);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = false;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // pnlMenuTop
            // 
            pnlMenuTop.BackColor = Color.FromArgb(236, 240, 245);
            pnlMenuTop.Controls.Add(lblMenu);
            pnlMenuTop.Dock = DockStyle.Top;
            pnlMenuTop.Location = new Point(0, 0);
            pnlMenuTop.Name = "pnlMenuTop";
            pnlMenuTop.Size = new Size(260, 90);
            pnlMenuTop.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMenu.ForeColor = Color.FromArgb(44, 62, 80);
            lblMenu.Location = new Point(28, 30);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(72, 30);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menü";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(249, 250, 252);
            pnlBottom.Controls.Add(lblDurum);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(260, 664);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(940, 36);
            pnlBottom.TabIndex = 2;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = Color.FromArgb(90, 98, 108);
            lblDurum.Location = new Point(16, 10);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(79, 15);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Sistem hazır...";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 245);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(1100, 650);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Personel Takip Sistemi";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlMenuTop.ResumeLayout(false);
            pnlMenuTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblBaslik;
        private Label lblAltBaslik;
        private Panel pnlSidebar;
        private Panel pnlMenuTop;
        private Label lblMenu;
        private Button btnPersonelYonetimi;
        private Button btnVardiyaYonetimi;
        private Button btnIzinYonetimi;
        private Button btnGorevYonetimi;
        private Panel pnlBottom;
        private Label lblDurum;
    }
}