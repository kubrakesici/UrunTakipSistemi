namespace EntityUrunTakipSistemi
{
    partial class FrmKategoriIslemleri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKatId = new System.Windows.Forms.TextBox();
            this.TxtKatAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID :";
            // 
            // TxtKatId
            // 
            this.TxtKatId.Enabled = false;
            this.TxtKatId.Location = new System.Drawing.Point(145, 36);
            this.TxtKatId.Name = "TxtKatId";
            this.TxtKatId.Size = new System.Drawing.Size(167, 33);
            this.TxtKatId.TabIndex = 1;
            // 
            // TxtKatAd
            // 
            this.TxtKatAd.Location = new System.Drawing.Point(145, 75);
            this.TxtKatAd.Name = "TxtKatAd";
            this.TxtKatAd.Size = new System.Drawing.Size(167, 33);
            this.TxtKatAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Ad :";
            // 
            // BtnListele
            // 
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnListele.Location = new System.Drawing.Point(26, 141);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(138, 36);
            this.BtnListele.TabIndex = 4;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSil.Location = new System.Drawing.Point(175, 183);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(138, 36);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnGuncelle.Location = new System.Drawing.Point(26, 183);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(138, 36);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnEkle.Location = new System.Drawing.Point(175, 141);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(138, 36);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 183);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmKategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(865, 255);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtKatAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKatId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKategoriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KATEGORİ İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKatId;
        private System.Windows.Forms.TextBox TxtKatAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

