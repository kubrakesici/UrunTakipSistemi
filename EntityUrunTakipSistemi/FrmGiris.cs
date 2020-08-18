using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunTakipSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            EntityUrunTakipEntities entity = new EntityUrunTakipEntities();

            var sorgu = from x in entity.AdminTable
                        where x.Username == TxtKullaniciAd.Text && x.Password == TxtSifre.Text
                        select x;

            if (sorgu.Any())
            {
                FrmAnaform frmAnaform = new FrmAnaform();
                frmAnaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
