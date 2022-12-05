using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    public class Acteur
    {
        [Key]
        public int ActeurId { get; set; }

        public string? Voornaam { get; set; }

        public string? Familienaam { get; set; }

        public DateTime? GeboorteDatum { get; set; }

        public string? GeboortePlaats { get; set; }

        public string? GeboorteLand { get; set; }

        //Navigation properties
        public List<FilmActeur> FilmActeurs { get; set; }
    }
}
