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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        EntityUrunTakipEntities entity = new EntityUrunTakipEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            ToplamKategori.Text = entity.CategoryTable.Count().ToString();
            ToplamUrun.Text = entity.ProductTable.Count().ToString();
            AktifMusteriNum.Text = entity.CustomerTable.Count(x => x.State == true).ToString();
            PasifMusteriNum.Text = entity.CustomerTable.Count(x => x.State == false).ToString();
            ToplamStok.Text = entity.ProductTable.Sum(y => y.Stock).ToString();
            EnPahaliUrun.Text = (from x in entity.ProductTable 
                                 orderby x.Price descending 
                                 select x.ProductName).FirstOrDefault();
            EnUcuzUrun.Text = (from y in entity.ProductTable
                               orderby y.Price ascending
                               select y.ProductName).FirstOrDefault();
            ToplamKazanc.Text = entity.SaleTable.Sum(x => x.Price) + " TL";

            BeyazesyaNum.Text = entity.ProductTable.Count(x => x.Category == 1).ToString();

            BuzdolabiSayisi.Text = entity.ProductTable.Count(x => x.ProductName == "Buzdolabı").ToString();

            SehirNum.Text = (from x in entity.CustomerTable
                             select x.CustomerCity).Distinct().Count().ToString();

            EnFazlaMarka.Text = entity.MARKAGETIR().FirstOrDefault();

        }
    }
}
