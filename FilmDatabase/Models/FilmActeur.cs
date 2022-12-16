using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
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
