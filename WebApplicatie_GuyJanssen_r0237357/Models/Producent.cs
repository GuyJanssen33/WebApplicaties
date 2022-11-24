using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    public class Producent
    {
        [Key]
        public int ProducentId { get; set; }

        public string Voornaam { get; set; }

        public string Familienaam { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public string GeboortePlaats { get; set; }

        public string GeboorteLand { get; set; }

        //navigation properties
        public List<FilmProducent> FilmProducenten { get; set; }
    }
}
