using Labb3.Bookstore_Forms;
using System;
using System.Windows.Forms;

namespace Labb3
{
    public partial class Köpsälj : Form
    {
        public object StoreSelect { get; }
        public static string selectedBook;
        //Antalselect = textbox för antal
        public Köpsälj()
        {
            InitializeComponent();
            using (var db = new LundellsBookstoreContext())
            {
                foreach (var bok in db.Böckers)
                {
                    BookSelect.Items.Add(bok.Titel);
                }
                selectedBook = (string)BookSelect.SelectedItem;
            }
        }
        private void Lagersaldoshortcut_Click(object sender, EventArgs e)
        {
            Saldo opensaldo = new Saldo();
            opensaldo.Show();
        }
        private void Executebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
