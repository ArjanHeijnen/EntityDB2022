using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Profiel
    {
        [Key]
        public int ProfielId { get; set; }
        public int GebruikerId { get; set; }
        public string? Taal { get; set; }
        public string? Naam { get; set; } = null!;
        public DateTime Geboortedatum { get; set; }
        public string? MediaVoorkeur { get; set; }
        public string? ProfielFoto { get; set; }
    }
}
