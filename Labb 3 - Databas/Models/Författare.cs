using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Författare
    {
        public Författare()
        {
            FörfattarBokJuncs = new HashSet<FörfattarBokJunc>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Födelsedatum { get; set; }

        public virtual ICollection<FörfattarBokJunc> FörfattarBokJuncs { get; set; }
    }
}
