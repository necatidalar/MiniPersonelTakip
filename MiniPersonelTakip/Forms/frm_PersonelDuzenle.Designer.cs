namespace MiniPersonelTakip
{
    partial class frm_PersonelDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpIseGiris = new DateTimePicker();
            txtTelefon = new TextBox();
            txtTckn = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(22, 219);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 23;
            label5.Text = "İşe Giriş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(22, 169);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 22;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(22, 119);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 21;
            label3.Text = "TC Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 20;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 19;
            label1.Text = "Ad";
            // 
            // dtpIseGiris
            // 
            dtpIseGiris.Location = new Point(22, 241);
            dtpIseGiris.Name = "dtpIseGiris";
            dtpIseGiris.Size = new Size(180, 23);
            dtpIseGiris.TabIndex = 18;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 9.75F);
            txtTelefon.Location = new Point(22, 191);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(180, 25);
            txtTelefon.TabIndex = 17;
            // 
            // txtTckn
            // 
            txtTckn.Font = new Font("Segoe UI", 9.75F);
            txtTckn.Location = new Point(22, 141);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(180, 25);
            txtTckn.TabIndex = 16;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 9.75F);
            txtSoyad.Location = new Point(22, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(180, 25);
            txtSoyad.TabIndex = 15;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 9.75F);
            txtAd.Location = new Point(22, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 25);
            txtAd.TabIndex = 14;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(22, 270);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(180, 35);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // frm_PersonelDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 324);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpIseGiris);
            Controls.Add(txtTelefon);
            Controls.Add(txtTckn);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnKaydet);
            Name = "frm_PersonelDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Düzenle";
            Load += frm_PersonelDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpIseGiris;
        private TextBox txtTelefon;
        private TextBox txtTckn;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnKaydet;
    }
}