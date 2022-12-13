using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
	
		[Table("Favoriet")]
		public class Favoriet
		{
			[Key]
			public int FavorietId { get; set; }
			[Required]
			public int FilmId { get; set; }
			[Required]
			public int GebruikerId { get; set; }

			//Navigation Properties
			public Gebruiker Gebruiker { get; set; }
			public Film Film { get; set; }
		}
	
}
