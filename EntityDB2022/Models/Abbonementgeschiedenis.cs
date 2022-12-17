using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Abbonementgeschiedenis
    {
        [Key]
        public int Id { get; set; }
        public DateTime Aanschaf_datum { get; set; }
        public DateTime? Afschat_datum { get; set; }
    }
}
