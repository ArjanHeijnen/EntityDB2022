using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Gebruiker
    {
        [Key]
        public int GebruikerId { get; set; }
        public string? Email { get; set; } = null!;
        public string? Wachtwoord { get; set; } = null!;
        public int Foutieve_inlog_Pogingen { get; set; }
        public bool Geactiveerd { get; set; }
        public int Proefversie_dagen { get; set; }
        public bool Korting { get; set; }
    }
}
