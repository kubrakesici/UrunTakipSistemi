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
    public partial class FrmKategoriIslemleri : Form
    {
        public FrmKategoriIslemleri()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKatId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKatAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        EntityUrunTakipEntities entity = new EntityUrunTakipEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entity.CategoryTable.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            CategoryTable kategori = new CategoryTable();
            kategori.CategoryName = TxtKatAd.Text;
            entity.CategoryTable.Add(kategori);
            entity.SaveChanges();

            MessageBox.Show("Kategori Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int katid = Convert.ToInt32(TxtKatId.Text);
            var kategori = entity.CategoryTable.Find(katid);
            entity.CategoryTable.Remove(kategori);
            entity.SaveChanges();

            MessageBox.Show("Kategori Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int katid = Convert.ToInt32(TxtKatId.Text);
            var kategori = entity.CategoryTable.Find(katid);
            kategori.CategoryName = TxtKatAd.Text;
            entity.SaveChanges();

            MessageBox.Show("Kategori Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      
    }
}
