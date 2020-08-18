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
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void BtnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri frmKategoriIslemleri = new FrmKategoriIslemleri();
            frmKategoriIslemleri.Show();
        }

        private void BtnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FrmUrunIslemleri frmUrunIslemleri = new FrmUrunIslemleri();
            frmUrunIslemleri.Show();
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();

        }
    }
}
