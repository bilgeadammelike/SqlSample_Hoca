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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShipperDAL dal = new ShipperDAL();
          int deger=  dal.ShipperAdd(new ShipperDAO() {
              CompanyName=txtName.Text,
              Phone=mstPhone.Text
          });

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in new ShipperDAL().ShipperSelect())
            {
                lstShippers.Items.Add(item);
            }
        }
    }
}
