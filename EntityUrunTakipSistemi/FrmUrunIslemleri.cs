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
    public partial class FrmUrunIslemleri : Form
    {
        public FrmUrunIslemleri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtUrunMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtUrunStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtUrunDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CmbUrunKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }


        EntityUrunTakipEntities entity = new EntityUrunTakipEntities();

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from urun in entity.ProductTable
                                        select new
                                        {
                                            urun.ProductId,
                                            urun.ProductName,
                                            urun.Brand,
                                            urun.Price,
                                            urun.Stock,
                                            urun.CategoryTable.CategoryName,
                                            urun.State
                                        }
                                        ).ToList();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            ProductTable urun = new ProductTable();
            urun.ProductName = TxtUrunAd.Text;
            urun.Brand = TxtUrunMarka.Text;
            urun.Stock = short.Parse(TxtUrunStok.Text);
            urun.Price = decimal.Parse(TxtUrunFiyat.Text);
            urun.State = true;
            urun.Category = int.Parse(CmbUrunKategori.SelectedValue.ToString());
            entity.ProductTable.Add(urun);
            entity.SaveChanges();

            MessageBox.Show("Ürün Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(TxtUrunId.Text);
            var urun = entity.ProductTable.Find(urunid);
            entity.ProductTable.Remove(urun);
            entity.SaveChanges();

            MessageBox.Show("Ürün Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(TxtUrunId.Text);
            var urun = entity.ProductTable.Find(urunid);

            urun.ProductName = TxtUrunAd.Text;
            urun.Brand = TxtUrunMarka.Text;
            urun.Stock = short.Parse(TxtUrunStok.Text);
            urun.Price = decimal.Parse(TxtUrunFiyat.Text);
            urun.State = bool.Parse(TxtUrunDurum.Text);
            urun.Category = int.Parse(CmbUrunKategori.Text);

            entity.SaveChanges();

            MessageBox.Show("Ürün Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmUrunIslemleri_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in entity.CategoryTable
                               select new
                               {
                                   x.CategoryName,
                                   x.CategoryId
                               }).ToList();

            CmbUrunKategori.ValueMember = "CategoryId";
            CmbUrunKategori.DisplayMember = "CategoryName";
            CmbUrunKategori.DataSource = kategoriler;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtUrunId.Text = "";
            TxtUrunAd.Text = "";
            TxtUrunMarka.Text = "";
            TxtUrunFiyat.Text = "";
            TxtUrunStok.Text = "";
            TxtUrunDurum.Text = "";
            CmbUrunKategori.Text = "";

        }
    }
}
