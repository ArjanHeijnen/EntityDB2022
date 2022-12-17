using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
      public class Kijklijst
    {
        [Key]
        public int ProfielId { get; set; }
        public int FilmId { get; set; } 
        public int SerieId { get; set; } 
    }
}
