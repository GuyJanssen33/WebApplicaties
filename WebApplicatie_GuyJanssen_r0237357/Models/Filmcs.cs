using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    public class Filmcs
    {
        [Key]
        public int FilmId { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Lengte { get; set; }

        [Required]
        public string Schrijver { get; set; }

        public string Samenvatting { get; set; }

        [Required]
        public DateTime ReleaseDatum { get; set; }

        [Required]
        public string Verdeler { get; set; }

        public string Rating { get; set; }

    }
}
