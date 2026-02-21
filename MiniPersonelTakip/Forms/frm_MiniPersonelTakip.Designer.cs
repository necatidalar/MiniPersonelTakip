namespace MiniPersonelTakip
{
    partial class frm_MiniPersonelTakip
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
            components = new System.ComponentModel.Container();
            dgvPersonel = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTckn = new TextBox();
            txtTelefon = new TextBox();
            dtpIseGiris = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            personelBindingSource = new BindingSource(components);
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tCKNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıseGirisTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonel.AutoGenerateColumns = false;
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.BackgroundColor = SystemColors.ControlLight;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, tCKNDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, ıseGirisTarihiDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dgvPersonel.DataSource = personelBindingSource;
            dgvPersonel.Location = new Point(218, 59);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(590, 327);
            dgvPersonel.TabIndex = 0;
            dgvPersonel.CellDoubleClick += dgvPersonel_CellDoubleClick;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(32, 310);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(180, 35);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(231, 76, 60);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(32, 351);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 35);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 9.75F);
            txtAd.Location = new Point(32, 81);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 25);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 9.75F);
            txtSoyad.Location = new Point(32, 131);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(180, 25);
            txtSoyad.TabIndex = 4;
            // 
            // txtTckn
            // 
            txtTckn.Font = new Font("Segoe UI", 9.75F);
            txtTckn.Location = new Point(32, 181);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(180, 25);
            txtTckn.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 9.75F);
            txtTelefon.Location = new Point(32, 231);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(180, 25);
            txtTelefon.TabIndex = 6;
            // 
            // dtpIseGiris
            // 
            dtpIseGiris.Location = new Point(32, 281);
            dtpIseGiris.Name = "dtpIseGiris";
            dtpIseGiris.Size = new Size(180, 23);
            dtpIseGiris.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(32, 59);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 8;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 9;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(32, 159);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 10;
            label3.Text = "TC Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(32, 209);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 11;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(32, 259);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 12;
            label5.Text = "İşe Giriş Tarihi";
            // 
            // personelBindingSource
            // 
            personelBindingSource.DataSource = typeof(Models.Personel);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tCKNDataGridViewTextBoxColumn
            // 
            tCKNDataGridViewTextBoxColumn.DataPropertyName = "TCKN";
            tCKNDataGridViewTextBoxColumn.HeaderText = "TCKN";
            tCKNDataGridViewTextBoxColumn.Name = "tCKNDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // ıseGirisTarihiDataGridViewTextBoxColumn
            // 
            ıseGirisTarihiDataGridViewTextBoxColumn.DataPropertyName = "IseGirisTarihi";
            ıseGirisTarihiDataGridViewTextBoxColumn.HeaderText = "İşe Giriş Tarihi";
            ıseGirisTarihiDataGridViewTextBoxColumn.Name = "ıseGirisTarihiDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frm_MiniPersonelTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 401);
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
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(dgvPersonel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_MiniPersonelTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Takip";
            Load += frm_MiniPersonelTakip_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvPersonel;
        private Button btnKaydet;
        private Button btnSil;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTckn;
        private TextBox txtTelefon;
        private DateTimePicker dtpIseGiris;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tCKNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıseGirisTarihiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private BindingSource personelBindingSource;
    }
}