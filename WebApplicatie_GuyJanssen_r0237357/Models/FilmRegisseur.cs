using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("FilmRegisseur")]
    public class FilmRegisseur
    {

        [Key]
        public int FilmRegisseurId { get; set; }
        public int FilmId { get; set; }
        public int RegisseurId { get; set; }

        //Navigation Properties
        [Required]
        public Regisseur Regisseurs { get; set; }
        [Required]
        public Film Films { get; set; }


    }
}
