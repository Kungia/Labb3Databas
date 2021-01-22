using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Ordrar
    {
        public double OrderId { get; set; }
        public string Kund { get; set; }
        public long Isbn { get; set; }
        public double Antal { get; set; }

        public virtual Böcker IsbnNavigation { get; set; }
    }
}
