using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
  public class Serie
    {
        [Key]
        public int SerieId { get; set; } 
        public string? Titel { get; set; }
        public string? Beschrijving { get; set; }

    }
}
