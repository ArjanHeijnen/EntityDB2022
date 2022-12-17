using EntityDB2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB2022.Data
{
    public class EntityContext : DbContext
    {
        public DbSet<Abbonementgeschiedenis> Abbonementgeschiedenissen { get; set; }
        public DbSet<Abbonnement> Abbonnementen { get; set; }
        public DbSet<Aflevering> Afleveringen { get; set; }
        public DbSet<Details> Detailss { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Genre_Voorkeur> Genre_Voorkeuren { get; set; }
        public DbSet<Kijklijst> Kijklijsten { get; set; }
        public DbSet<Kijkwijzer> Kijkwijzers { get; set; }
        public DbSet<Kijkwijzer_voorkeur> Kijkwijzer_voorkeuren { get; set; }
        public DbSet<Ondertiteling> Ondertitelingen { get; set; }
        public DbSet<Profiel> Profielen { get; set; }
        public DbSet<Seizoen> Seizoenen { get; set; }
        public DbSet<Serie> Series { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EntityDB2022;Integrated Security=True");

        }
    }
}
