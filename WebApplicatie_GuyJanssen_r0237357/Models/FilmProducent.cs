using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("FilmProducent")]
    public class FilmProducent
    {
        [Key]
        public int FilmProducentId { get; set; }
        [Required]
        public int FilmId { get; set; }
		[Required]
		public int ProducentId { get; set; }

        //Navigation Properties
        public Producent Producenten { get; set; }
        public Film Films { get; set; }

    }
}
