using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_3___Databas
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm___Lundells_Bookstore_Load(object sender, EventArgs e)
        {

        }

        private void LagersaldoStoreSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LagersaldoBtn_Click(object sender, EventArgs e)
        {
            Lagersaldo lagersaldo = new Lagersaldo();
            lagersaldo.Show();
            
        }

        private void BuySellBtn_Click(object sender, EventArgs e)
        {
            KöpSälj köpsälj = new KöpSälj();
            köpsälj.Show();
        }
    }
}
