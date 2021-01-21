using Labb_3___Databas.Data;
using Labb_3___Databas.Models;
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
    public partial class KöpSälj : Form
    {
        public KöpSälj()
        {
            InitializeComponent();
            using (var db = new LundellsBookstoreContext())
            {


            }
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
