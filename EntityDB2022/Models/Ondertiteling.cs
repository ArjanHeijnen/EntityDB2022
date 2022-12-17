using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Ondertiteling
    {
        [Key]
        public int OndertitelingId { get; set; }
        public int FilmId { get; set; }
        public int AfleveringId { get; set; }
        public string? Taal { get; set; }
    }
}
