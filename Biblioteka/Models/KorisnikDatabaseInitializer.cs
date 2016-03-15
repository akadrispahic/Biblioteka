using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace Biblioteka.Models
{
    public class KorisnikDatabaseInitializer : DropCreateDatabaseIfModelChanges<KorisnikContext>
    {


        protected override void Seed(KorisnikContext context)
        {
            GetKorisnik().ForEach(c => context.Korisnik.Add(c));
            GetClanstvo().ForEach(p => context.Clanstvo.Add(p));
            GetTipRacuna().ForEach(r => context.TipRacuna.Add(r));
        }
        private static List<Korisnik> GetKorisnik()
        {
            var korisnici = new List<Korisnik> {
                new Korisnik
                {
                    KorisnikID=1,
                    Ime = "AMina",
                    Prezime ="Kadrispahic",
                    Telefon ="061307658",
                    Adresa ="Alekse Santica 65",
                    Email ="amina.k",
                    Username ="aminica",
                    Password ="tel123",
                    izbrisan =false,
                    odobren =true,
                    TipRacunaID=1

                },

                 new Korisnik
                {
                    KorisnikID=2,
                    Ime = "Ilma",
                    Prezime ="Kurtovic",
                    Telefon ="062545478",
                    Adresa ="Alekse Santica 65",
                    Email ="ilmica.k",
                    Username ="ilmaaa",
                    Password ="tel123",
                    izbrisan =false,
                    odobren =true,
                    TipRacunaID=2

                },

            };

            return korisnici;
        }
        private static List<Clanstvo> GetClanstvo()
        {
            var clanstva = new List<Clanstvo> {
                new Clanstvo
                {
                    ClanstvoID = 1,
                   // DatumRacuna ,
                    //IstekRacuna=null,
                    ClanskiBroj= 100,
                    KorisnikID =1

               },
                new Clanstvo
                {
                    ClanstvoID = 2,
                   // DatumRacuna=
                   // IstekRacuna=
                    ClanskiBroj= 101,
                    KorisnikID =2

               }

            };

            return clanstva;
        }
        private static List<TipRacuna> GetTipRacuna()
        {
            var tipovi = new List<TipRacuna>
            {
                new TipRacuna
                {
                    TipRacunaID=1,
                    Referenca="nesto",
                    Opis="neki opis"
                 },
                new TipRacuna
                {
                    TipRacunaID=2,
                    Referenca="nesto",
                    Opis="neki opis"
                 },

            };
            return tipovi;
        }
    }
}