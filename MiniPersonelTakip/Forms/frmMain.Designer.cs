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
            lblBaslik = new Label();
            btnPersonelYonetimi = new Button();
            btnVardiyaYonetimi = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.Location = new Point(38, 29);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(258, 30);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 254);
            Controls.Add(btnVardiyaYonetimi);
            Controls.Add(btnPersonelYonetimi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}