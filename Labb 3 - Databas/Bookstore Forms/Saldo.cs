using System;
using System.Linq;
using System.Windows.Forms;

namespace Labb3
{
    public partial class Saldo : Form
    {
        private string selectedStore = BaseForm.selectedStore;
        public Saldo()
        {
            InitializeComponent();
         //   using (var db = new LundellsBookstoreContext())
            {
           
                //db.Lagersaldos.Select(i => i);
            }
        }

        private void Lagersaldo___Lundells_Bookstore_Load(object sender, EventArgs e)
        {
            Saldo lagersaldo = new Saldo();
            lagersaldo.Show();
        }

        private void KöpSäljbtn_Click(object sender, EventArgs e)
        {
            Köpsälj köpsälj = new Köpsälj();
            köpsälj.Show();
        }


    }
}
