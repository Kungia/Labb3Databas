﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Databas.Models
{
    [Table("Böcker")]
    class Bok
    {
        public int Id { get; set; }
        [Column("Titel")]
        public string Name { get; set; }
    }
}
