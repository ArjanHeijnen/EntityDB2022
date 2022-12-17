using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string? GenreNaam { get; set; }
        public string? Beschrijving { get; set; }
    }
}
