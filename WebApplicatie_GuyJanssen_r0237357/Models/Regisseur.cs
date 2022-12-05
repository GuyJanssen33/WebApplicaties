using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("Regisseur")]
    public class Regisseur
    {
        [Key]
        public int RegisseurId { get; set; }

        public string? Voornaam { get; set; }

        public string? Familienaam { get; set; }

        public DateTime? GeboorteDatum { get; set; }

        public string? GeboortePlaats { get; set; }

        public string? GeboorteLand { get; set; }

        //Navigation properties
        
        public List<FilmRegisseur> FilmRegisseurs { get; set; }
    }
}
