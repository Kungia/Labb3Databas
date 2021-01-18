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
        public int Id { get; set; }

        [Column("ISBN")]
        public float ISBN { get; set; }

    }
}
