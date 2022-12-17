using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Models
{
    public class Kijkwijzer_voorkeur
    {

        [Key]
        public int ProfielId { get; set; }
        public int KijkwijzerId { get; set; }
    }
}
