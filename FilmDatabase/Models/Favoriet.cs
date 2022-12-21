using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FilmDatabase.Areas.Identity.Data;

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
			public CustomUser CustomUser { get; set; }
			public Film Film { get; set; }
		}
	
}
