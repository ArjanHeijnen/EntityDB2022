using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022  .Models
{
  public class Aflevering
    {
        [Key]
        public int AfleveringId { get; set; }
        public int SeizoenId { get; set; }
        public string? Titel { get; set; }
        public string? Kwaliteit { get; set; }
        public int Looptijd { get; set; }
        public int AftitelingStart { get; set; }
        public string? Beschrijving { get; set; }
    }
}
