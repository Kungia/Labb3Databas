using Labb3.Bookstore_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Labb3
{
    public partial class BaseForm : Form
    {
        public static string selectedStore;
        public static List<Butiker> butikslista = new List<Butiker>();
        public BaseForm()
        {
            InitializeComponent();
            using (var db = new LundellsBookstoreContext())

            {
               foreach (var butik in db.Butikers)
                {
                    butikslista.Add(butik);            
                }
                StoreSelect.DataSource = butikslista.Select(i => i.Butiksnamn).ToList();            
            }
        }

        private void LagersaldoBtn_Click(object sender, EventArgs e)
        {
            Saldo opensaldo = new Saldo();
            opensaldo.Show();

        }
        private void BuySellBtn_Click(object sender, EventArgs e)
        {
            Köpsälj köpsälj = new Köpsälj();
            köpsälj.Show();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void StoreSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStore = StoreSelect.SelectedItem.ToString();
        }
    }
}