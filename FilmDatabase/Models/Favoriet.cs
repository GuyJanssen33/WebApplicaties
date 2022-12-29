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
			public string CustomUserId { get; set; }

		//Navigation Properties
			//[ForeignKey("CustomUserId")]
			//public CustomUser CustomUsers { get; set; }
			public Film Films { get; set; }
		}
	
}
