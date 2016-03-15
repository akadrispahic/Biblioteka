using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Clanstvo
    {
        [ScaffoldColumn(false)]
        public int ClanstvoID { get; set; }

        public DateTime DatumRacuna { get; set; }
        public DateTime IstekRacuna { get; set; }
        public int ClanskiBroj { get; set; }
        public int? KorisnikID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}