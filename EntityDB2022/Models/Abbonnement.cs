using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Abbonnement
    {
        [Key]
        public int AbboId { get; set; }
        public string? Omschrijving { get; set; } 
        public decimal Price { get; set; }

    }
}
