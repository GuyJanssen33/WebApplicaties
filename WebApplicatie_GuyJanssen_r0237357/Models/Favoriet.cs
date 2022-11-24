using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("Favoriet")]
    public class Favoriet
    {
        [Key]
        public int FavorietId { get; set; }
        public int FilmId { get; set; }
        public int GebruikerId { get; set; }

        //Navigation Properties
        public Gebruiker Gebruiker { get; set; }
        public Film Film { get; set; }
    }
}
