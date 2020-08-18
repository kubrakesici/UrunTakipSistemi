namespace EntityUrunTakipSistemi
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(192, 40);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(207, 33);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(192, 79);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(207, 33);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGirisYap.Location = new System.Drawing.Point(270, 118);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(129, 38);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "GİRİŞ YAP";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(491, 200);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}