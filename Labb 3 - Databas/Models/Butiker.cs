using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Butiker
    {
        public Butiker()
        {
            Lagersaldos = new HashSet<Lagersaldo>();
        }

        public int IdentityId { get; set; }
        public string Butiksnamn { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Lagersaldo> Lagersaldos { get; set; }
    }
}
