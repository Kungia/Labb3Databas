using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class FörfattarBokJunc
    {
        public int Id { get; set; }
        public long Isbn13 { get; set; }

        public virtual Författare IdNavigation { get; set; }
        public virtual Böcker Isbn13Navigation { get; set; }
    }
}
