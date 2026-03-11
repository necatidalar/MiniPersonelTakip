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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblBaslik = new Label();
            btnPersonelYonetimi = new Button();
            btnVardiyaYonetimi = new Button();
            btnIzinYonetimi = new Button();
            btnGorevYonetimi = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.Location = new Point(38, 29);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(243, 30);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Personel Takip Sistemi";
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.BackColor = Color.FromArgb(52, 152, 219);
            btnPersonelYonetimi.FlatAppearance.BorderSize = 0;
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPersonelYonetimi.ForeColor = Color.White;
            btnPersonelYonetimi.Location = new Point(42, 92);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(240, 48);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = false;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // btnVardiyaYonetimi
            // 
            btnVardiyaYonetimi.BackColor = Color.FromArgb(46, 204, 113);
            btnVardiyaYonetimi.FlatAppearance.BorderSize = 0;
            btnVardiyaYonetimi.FlatStyle = FlatStyle.Flat;
            btnVardiyaYonetimi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVardiyaYonetimi.ForeColor = Color.White;
            btnVardiyaYonetimi.Location = new Point(42, 156);
            btnVardiyaYonetimi.Name = "btnVardiyaYonetimi";
            btnVardiyaYonetimi.Size = new Size(240, 48);
            btnVardiyaYonetimi.TabIndex = 2;
            btnVardiyaYonetimi.Text = "Vardiya Yönetimi";
            btnVardiyaYonetimi.UseVisualStyleBackColor = false;
            btnVardiyaYonetimi.Click += btnVardiyaYonetimi_Click;
            // 
            // btnIzinYonetimi
            // 
            btnIzinYonetimi.BackColor = Color.FromArgb(155, 89, 182);
            btnIzinYonetimi.FlatAppearance.BorderSize = 0;
            btnIzinYonetimi.FlatStyle = FlatStyle.Flat;
            btnIzinYonetimi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzinYonetimi.ForeColor = Color.White;
            btnIzinYonetimi.Location = new Point(42, 220);
            btnIzinYonetimi.Name = "btnIzinYonetimi";
            btnIzinYonetimi.Size = new Size(240, 48);
            btnIzinYonetimi.TabIndex = 3;
            btnIzinYonetimi.Text = "İzin Yönetimi";
            btnIzinYonetimi.UseVisualStyleBackColor = false;
            btnIzinYonetimi.Click += btnIzinYonetimi_Click;
            // 
            // btnGorevYonetimi
            // 
            btnGorevYonetimi.BackColor = Color.FromArgb(241, 196, 15);
            btnGorevYonetimi.FlatAppearance.BorderSize = 0;
            btnGorevYonetimi.FlatStyle = FlatStyle.Flat;
            btnGorevYonetimi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGorevYonetimi.ForeColor = Color.White;
            btnGorevYonetimi.Location = new Point(42, 284);
            btnGorevYonetimi.Name = "btnGorevYonetimi";
            btnGorevYonetimi.Size = new Size(240, 48);
            btnGorevYonetimi.TabIndex = 4;
            btnGorevYonetimi.Text = "Görev Yönetimi";
            btnGorevYonetimi.UseVisualStyleBackColor = false;
            btnGorevYonetimi.Click += btnGorevYonetimi_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 370);
            Controls.Add(btnIzinYonetimi);
            Controls.Add(btnVardiyaYonetimi);
            Controls.Add(btnPersonelYonetimi);
            Controls.Add(btnGorevYonetimi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblBaslik;
        private Button btnPersonelYonetimi;
        private Button btnVardiyaYonetimi;
        private Button btnIzinYonetimi;
        private Button btnGorevYonetimi;
    }
}