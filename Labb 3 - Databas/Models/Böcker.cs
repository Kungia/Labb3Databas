using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Böcker
    {
        public Böcker()
        {
            FörfattarBokJuncs = new HashSet<FörfattarBokJunc>();
            Lagersaldos = new HashSet<Lagersaldo>();
        }

        public long Isbn13 { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public double Pris { get; set; }
        public int Utgivningsår { get; set; }

        public virtual Förlag Förlag { get; set; }
        public virtual Ordrar Ordrar { get; set; }
        public virtual ICollection<FörfattarBokJunc> FörfattarBokJuncs { get; set; }
        public virtual ICollection<Lagersaldo> Lagersaldos { get; set; }
    }
}
