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
            pnlContainer = new Panel();
            pnlTop.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMenuTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(28, 30, 38);
            pnlTop.Controls.Add(lblAltBaslik);
            pnlTop.Controls.Add(lblBaslik);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(260, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(940, 90);
            pnlTop.TabIndex = 0;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAltBaslik.ForeColor = Color.FromArgb(140, 145, 155);
            lblAltBaslik.Location = new Point(28, 55);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(223, 17);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Personel, izin, vardiya ve görev takibi";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(24, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(238, 32);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Mini Personel Takip";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(20, 22, 27);
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
            btnGorevYonetimi.BackColor = Color.Transparent;
            btnGorevYonetimi.Dock = DockStyle.Top;
            btnGorevYonetimi.FlatAppearance.BorderSize = 0;
            btnGorevYonetimi.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 48, 55);
            btnGorevYonetimi.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 38, 45);
            btnGorevYonetimi.FlatStyle = FlatStyle.Flat;
            btnGorevYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGorevYonetimi.ForeColor = Color.FromArgb(170, 175, 185);
            btnGorevYonetimi.Location = new Point(0, 255);
            btnGorevYonetimi.Name = "btnGorevYonetimi";
            btnGorevYonetimi.Padding = new Padding(30, 0, 0, 0);
            btnGorevYonetimi.Size = new Size(260, 55);
            btnGorevYonetimi.TabIndex = 4;
            btnGorevYonetimi.Text = "Görev Yönetimi";
            btnGorevYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnGorevYonetimi.UseVisualStyleBackColor = false;
            btnGorevYonetimi.Click += btnGorevYonetimi_Click;
            // 
            // btnIzinYonetimi
            // 
            btnIzinYonetimi.BackColor = Color.Transparent;
            btnIzinYonetimi.Dock = DockStyle.Top;
            btnIzinYonetimi.FlatAppearance.BorderSize = 0;
            btnIzinYonetimi.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 48, 55);
            btnIzinYonetimi.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 38, 45);
            btnIzinYonetimi.FlatStyle = FlatStyle.Flat;
            btnIzinYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIzinYonetimi.ForeColor = Color.FromArgb(170, 175, 185);
            btnIzinYonetimi.Location = new Point(0, 200);
            btnIzinYonetimi.Name = "btnIzinYonetimi";
            btnIzinYonetimi.Padding = new Padding(30, 0, 0, 0);
            btnIzinYonetimi.Size = new Size(260, 55);
            btnIzinYonetimi.TabIndex = 3;
            btnIzinYonetimi.Text = "İzin Yönetimi";
            btnIzinYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnIzinYonetimi.UseVisualStyleBackColor = false;
            btnIzinYonetimi.Click += btnIzinYonetimi_Click;
            // 
            // btnVardiyaYonetimi
            // 
            btnVardiyaYonetimi.BackColor = Color.Transparent;
            btnVardiyaYonetimi.Dock = DockStyle.Top;
            btnVardiyaYonetimi.FlatAppearance.BorderSize = 0;
            btnVardiyaYonetimi.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 48, 55);
            btnVardiyaYonetimi.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 38, 45);
            btnVardiyaYonetimi.FlatStyle = FlatStyle.Flat;
            btnVardiyaYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnVardiyaYonetimi.ForeColor = Color.FromArgb(170, 175, 185);
            btnVardiyaYonetimi.Location = new Point(0, 145);
            btnVardiyaYonetimi.Name = "btnVardiyaYonetimi";
            btnVardiyaYonetimi.Padding = new Padding(30, 0, 0, 0);
            btnVardiyaYonetimi.Size = new Size(260, 55);
            btnVardiyaYonetimi.TabIndex = 2;
            btnVardiyaYonetimi.Text = "Vardiya Yönetimi";
            btnVardiyaYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnVardiyaYonetimi.UseVisualStyleBackColor = false;
            btnVardiyaYonetimi.Click += btnVardiyaYonetimi_Click;
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.BackColor = Color.Transparent;
            btnPersonelYonetimi.Dock = DockStyle.Top;
            btnPersonelYonetimi.FlatAppearance.BorderSize = 0;
            btnPersonelYonetimi.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 48, 55);
            btnPersonelYonetimi.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 38, 45);
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPersonelYonetimi.ForeColor = Color.FromArgb(170, 175, 185);
            btnPersonelYonetimi.Location = new Point(0, 90);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Padding = new Padding(30, 0, 0, 0);
            btnPersonelYonetimi.Size = new Size(260, 55);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Tag = "frm_PersonelYonetimi";
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonelYonetimi.UseVisualStyleBackColor = false;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // pnlMenuTop
            // 
            pnlMenuTop.BackColor = Color.Transparent;
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
            lblMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(26, 35);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(150, 21);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "ANA KONTROLLER";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(28, 30, 38);
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
            lblDurum.ForeColor = Color.FromArgb(140, 145, 155);
            lblDurum.Location = new Point(16, 10);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(79, 15);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Sistem hazır...";
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(18, 18, 18);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(260, 90);
            pnlContainer.Margin = new Padding(10);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(940, 574);
            pnlContainer.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 45);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlContainer);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 650);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Personel Takip Sistemi";
            WindowState = FormWindowState.Maximized;
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
        private Panel pnlContainer;
    }
}