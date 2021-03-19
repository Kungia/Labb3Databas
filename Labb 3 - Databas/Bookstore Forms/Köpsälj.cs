using Labb3.Bookstore_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Labb3
{
    public partial class Köpsälj : Form
    {
        public string selectedstore = BaseForm.selectedStore;
        public int storeID;
        List<Böcker> booklist = new List<Böcker>();
        Dictionary<Böcker, Lagersaldo> bokmatch = new Dictionary<Böcker, Lagersaldo>();
        public Köpsälj()
        {
            InitializeComponent();
            storeID = BaseForm.butikslista.Where(i => i.Butiksnamn == selectedstore).Select(i => i.IdentityId).First();
            using (var db = new LundellsBookstoreContext())
            {
                foreach (var item in db.Böckers.Select(i => i).Where(i => i.Lagersaldos.Any(i => i.ButikId == storeID)))
                {
                    booklist.Add(item);
                }
                BookSelect.DataSource = booklist.Select(i => i.Titel).ToList();
            }
        }

        private void Lagersaldoshortcut_Click(object sender, EventArgs e)
        {
            Saldo opensaldo = new Saldo();
            opensaldo.Show();
        }
        private void Executebtn_Click(object sender, EventArgs e)
        {
            using (var db = new LundellsBookstoreContext())
            {
                string valdbok = BookSelect.SelectedItem.ToString();
                int antal = Int32.Parse(AntalSelect.Text.ToString());

                foreach (var book in booklist)
                {
                    if (valdbok == book.Titel)
                    {

                        var item = (Lagersaldo)db.Lagersaldos.Select(i => i).Where(i => i.Isbn == book.Isbn13).First();

                        if (item.ButikId == storeID)
                        {
                            if (RadioKöp.Checked)
                            {
                                item.Antal += antal;
                            }
                            else if (RadioSälj.Checked)
                            {
                                item.Antal -= antal;
                            }
                            db.Lagersaldos.Update(item);
                        }
                    }
                }
                db.SaveChanges();
                BookSelect.DataSource = booklist.Select(i => i.Titel).ToList();
                
            }
        }
    }
}

