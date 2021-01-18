using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Databas.Models
{
    [Table("Butiker")]
    class Butik
    {
        [Column ("IdentityID")]
        public int Id { get; set; }

        [Column("Butiksnamn")]
        public string Name { get; set; }

        [Column("Adress")]
        public string Adress { get; set; }
    }
}
