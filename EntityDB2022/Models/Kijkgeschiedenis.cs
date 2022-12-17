using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityDB2022.Models
{
    public class Kijkgeschiedenis
    {
        [Key]
        public int KijkgeschiedenisId { get; set; }
        public int ProfielId { get; set; }
        public int FilmId { get; set; }
        public int AfleveringId { get; set; }
        public int OndertitelingId { get; set; }
        public int Pauzetijd { get; set; }
    }
}
