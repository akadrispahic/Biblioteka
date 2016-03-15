using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Biblioteka.Models
{
    public class KorisnikContext : DbContext
    {
        public KorisnikContext() : base("Biblioteka")
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Clanstvo> Clanstvo { get; set; }
        public DbSet<TipRacuna> TipRacuna { get; set; }

    }
}