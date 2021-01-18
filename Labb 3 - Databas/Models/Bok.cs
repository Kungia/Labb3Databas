using System;
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
        [Column("ISBN13")]
        public float Id { get; set; }

        [Column("Titel")]
        public string Titel { get; set; }

        [Column("Språk")]
        public string Språk { get; set; }

        [Column("Pris")]
        public float Pris { get; set; }

        [Column("Utgivningsår")]
        public int År { get; set; }
    }
}
