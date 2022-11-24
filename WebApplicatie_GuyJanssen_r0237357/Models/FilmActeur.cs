using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("FilmActeur")]
    public class FilmActeur
    {
        [Key]
        public int FilmActeurId { get; set; }

        [Required]
        public int FilmId { get; set; }

        [Required]
        public int ActeurId { get; set; }

        [Required]
        public string Personage { get; set; }

        //Navigation Properties
        public Acteur Acteur { get; set; }
        public Film Film { get; set; }
    }
}
