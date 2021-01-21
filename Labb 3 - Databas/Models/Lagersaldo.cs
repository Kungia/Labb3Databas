using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Databas.Models
{
    [Table("Lagersaldo")]
    class Lagersaldo
    {
        [Column("ButikID")]
        public int Id { get; set; }

        [Column("ISBN")]
        public float ISBN { get; set; }

        [Column("Antal")]
        public int Antal { get; set; }

    }
}
