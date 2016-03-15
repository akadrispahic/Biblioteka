using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Biblioteka.Models
{
    public class TipRacuna
    {
        [ScaffoldColumn(false)]
        public int TipRacunaID { get; set; }

        [Required, StringLength(45), Display(Name = "Referenca")]
        public string Referenca { get; set; }

        [Required, StringLength(45), Display(Name = "Opis")]
        public string Opis { get; set; }
    }
}