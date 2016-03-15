using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Biblioteka.Models
{
    public class Korisnik
    {
        [ScaffoldColumn(false)]
        public int KorisnikID { get; set; }

        [Required, StringLength(45), Display(Name = "Ime")]
        public string Ime { get; set; }
        [Required, StringLength(45), Display(Name = "Prezime")]
        public string Prezime { get; set; }
        [Required, StringLength(45), Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Required, StringLength(45), Display(Name = "Adresa")]
        public string Adresa { get; set; }
        [Required, StringLength(45), Display(Name = "Email ")]
        public string Email { get; set; }
        [Required, StringLength(45), Display(Name = "Username")]
        public string Username { get; set; }
        [Required, StringLength(45), Display(Name = "Password")]
        public string Password { get; set; }

        public Boolean izbrisan { get; set; }
        public Boolean odobren { get; set; }
        public int? TipRacunaID { get; set; }
        public virtual TipRacuna TipRacuna { get; set; }
    }
}