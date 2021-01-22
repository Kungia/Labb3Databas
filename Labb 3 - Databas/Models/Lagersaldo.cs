﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3
{
    public partial class Lagersaldo
    {
        public int ButikId { get; set; }
        public long Isbn { get; set; }
        public int Antal { get; set; }

        public virtual Butiker Butik { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
