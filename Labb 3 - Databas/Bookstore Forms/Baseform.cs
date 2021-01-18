using Labb_3___Databas.Data;
using System;
using System.Windows.Forms;

namespace Labb_3___Databas
{
    public partial class BaseForm : Form
    {
        public static string selectedStore;
        public BaseForm()
        {
            InitializeComponent();
            using (var db = new LundellsBookstoreContext())
            {
                foreach (var butik in db.Butiker)
                {
                    StoreSelect.Items.Add(butik.Name);
                }
                
            }
            selectedStore = (string)StoreSelect.SelectedItem;
        }

        private void BaseForm___Lundells_Bookstore_Load(object sender, EventArgs e)
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
