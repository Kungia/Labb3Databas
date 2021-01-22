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
            // using (var db = new LundellsBookstoreContext())
            // {
            //     foreach (var item in db.Böcker.ToList())
            //     {
            //         BookSelect.Items.Add(item.Titel);
            //     }
            //     selectedBook = (string)BookSelect.SelectedItem;
            // }
        }
        private void Lagersaldoshortcut_Click(object sender, EventArgs e)
        {
            Lagersaldo lagersaldo = new Lagersaldo();
            lagersaldo.Show();
        }
        private void Executebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
