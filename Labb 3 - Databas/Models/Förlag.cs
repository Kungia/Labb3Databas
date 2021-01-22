using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Förlag
    {
        public double FörlagsId { get; set; }
        public string Förlagsnamn { get; set; }
        public long Isbn { get; set; }

        public virtual Böcker IsbnNavigation { get; set; }
    }
}
