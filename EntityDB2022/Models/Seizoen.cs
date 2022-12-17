using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Seizoen
    {
        [Key]
        public int SeizoenId { get; set; }
        public int SerieId { get; set; }
        public int SeizoenNummer { get; set; }
        public string? Beschrijving { get; set; }
    }
}
