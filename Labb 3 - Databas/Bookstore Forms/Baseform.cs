using System;
using System.Windows.Forms;

namespace Labb3
{
    public partial class BaseForm : Form
    {
        public static string selectedStore;
        public BaseForm()
        {
            InitializeComponent();
          //  using (var db = new LundellsBookstoreContext())
          //  {
          //     foreach (var butik in db.Butikers)
          //      {
          //          StoreSelect.Items.Add(butik.Butiksnamn);
          //          
          //      }
          //  }
          //  selectedStore = (string)StoreSelect.SelectedItem;
        }

        private void LagersaldoBtn_Click(object sender, EventArgs e)
        {
            Saldo lagersaldo = new Saldo();
            lagersaldo.Show();

        }
        private void BuySellBtn_Click(object sender, EventArgs e)
        {
            Köpsälj köpsälj = new Köpsälj();
            köpsälj.Show();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}