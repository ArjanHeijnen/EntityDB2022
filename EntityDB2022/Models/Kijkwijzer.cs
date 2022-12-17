using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
  public class Kijkwijzer
    {
        [Key]
        public int KijkwijzerId { get; set; }
        public string? KijkwijzerNaam { get; set; }
        public string? Beschrijving { get; set; }
    }
}
