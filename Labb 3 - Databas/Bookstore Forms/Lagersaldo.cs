using Labb_3___Databas.Data;
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
    public partial class Lagersaldo : Form
    {
        private string selectedStore = BaseForm.selectedStore;
        public Lagersaldo()
        {
            InitializeComponent();
            using (var db = new LundellsBookstoreContext())
            {
                //LagersaldoDb.DataSource = db.Lagersaldos;
            }
        }

        private void Lagersaldo___Lundells_Bookstore_Load(object sender, EventArgs e)
        {

        }

        private void KöpSäljbtn_Click(object sender, EventArgs e)
        {
            KöpSälj köpSälj = new KöpSälj();
            köpSälj.Show();
        }


    }
}
