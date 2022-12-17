using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Details
    {
        [Key]
        public int KijkwijzerId { get; set; }
        public int GenreId { get; set; }
        public int FilmId { get; set; }
        public int SerienId { get; set; }
    }
}
