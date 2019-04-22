using SqlSample.DAL;
using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSample.WinUI
{
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            ErisimKontrolu();
            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {
            foreach (var item in new CategoryDAL().Select())
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void ErisimKontrolu()
        {
            txtStokMiktari.Enabled = txtUurunAdi.Enabled = lstUrun.Enabled = numericUpDown1.Enabled = false;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUrun.Items.Clear();
            CategoryDAO secilenUrun = cmbKategori.SelectedItem as CategoryDAO;
            foreach (var item in new ProductDAL().SelectByID(Convert.ToInt32(secilenUrun.ID)))
            {
                lstUrun.Items.Add(item);
            }
            lstUrun.Enabled = true;
            
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDAO dao= lstUrun.SelectedItem as ProductDAO;
            txtStokMiktari.Text = dao.UnitsInStock.ToString();
            txtUurunAdi.Text = dao.ProductName;
            numericUpDown1.Enabled = true;
        }

        List<SepetItem> sepetim = new List<SepetItem>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null)
            {
                erpSepet.SetError(txtUurunAdi, "hata varrrr");

            }
            else
            {
                erpSepet.Clear();
                sepetim.Add(new SepetItem()
                {
                    Adet = Convert.ToInt32(numericUpDown1.Value),
                    dao = lstUrun.SelectedItem as ProductDAO
                });
            }

       

            //if (sepetim.Count == 0)
            //{
            //    //ilk 
            //}
            //else
            //{
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
