using System.ComponentModel.DataAnnotations;
using System;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    public class Regisseur
    {
        [Key]
        public int RegisseurId { get; set; }

        public string Voornaam { get; set; }

        public string Familienaam { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public string GeboortePlaats { get; set; }

        public string GeboorteLand { get; set; }
    }
}
