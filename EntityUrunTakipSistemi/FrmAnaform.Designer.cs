namespace EntityUrunTakipSistemi
{
    partial class FrmAnaform
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
            this.BtnKategoriIslemleri = new System.Windows.Forms.Button();
            this.BtnUrunIslemleri = new System.Windows.Forms.Button();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategoriIslemleri
            // 
            this.BtnKategoriIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKategoriIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKategoriIslemleri.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnKategoriIslemleri.Location = new System.Drawing.Point(12, 12);
            this.BtnKategoriIslemleri.Name = "BtnKategoriIslemleri";
            this.BtnKategoriIslemleri.Size = new System.Drawing.Size(171, 144);
            this.BtnKategoriIslemleri.TabIndex = 0;
            this.BtnKategoriIslemleri.Text = "KATEGORİ İŞLEMELERİ";
            this.BtnKategoriIslemleri.UseVisualStyleBackColor = true;
            this.BtnKategoriIslemleri.Click += new System.EventHandler(this.BtnKategoriIslemleri_Click);
            // 
            // BtnUrunIslemleri
            // 
            this.BtnUrunIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrunIslemleri.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnUrunIslemleri.Location = new System.Drawing.Point(198, 12);
            this.BtnUrunIslemleri.Name = "BtnUrunIslemleri";
            this.BtnUrunIslemleri.Size = new System.Drawing.Size(171, 144);
            this.BtnUrunIslemleri.TabIndex = 1;
            this.BtnUrunIslemleri.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnUrunIslemleri.UseVisualStyleBackColor = true;
            this.BtnUrunIslemleri.Click += new System.EventHandler(this.BtnUrunIslemleri_Click);
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIstatistik.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnIstatistik.Location = new System.Drawing.Point(384, 12);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(171, 144);
            this.BtnIstatistik.TabIndex = 2;
            this.BtnIstatistik.Text = "İSTATİSTİK";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            this.BtnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // FrmAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(569, 166);
            this.Controls.Add(this.BtnIstatistik);
            this.Controls.Add(this.BtnUrunIslemleri);
            this.Controls.Add(this.BtnKategoriIslemleri);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategoriIslemleri;
        private System.Windows.Forms.Button BtnUrunIslemleri;
        private System.Windows.Forms.Button BtnIstatistik;
    }
}