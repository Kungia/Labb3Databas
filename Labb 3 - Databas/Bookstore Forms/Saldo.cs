using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb3.Bookstore_Forms
{
    public partial class Saldo : Form
    {
        public string selectedstore = BaseForm.selectedStore;
        public int storeID;
        public List<Lagersaldo> butikssaldo = new List<Lagersaldo>();
        public Saldo()
        {
            InitializeComponent();
            storeID = BaseForm.butikslista.Where(i => i.Butiksnamn == selectedstore).Select(i => i.IdentityId).First();
            using (var db = new LundellsBookstoreContext())
            {
                foreach (var item in db.Lagersaldos.Where(i=> i.ButikId == storeID))
                {
                    butikssaldo.Add(item);
                }
                datatable.DataSource = butikssaldo;       
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Köpsälj köpsälj = new Köpsälj();
            köpsälj.Show();
        }
    }
}
