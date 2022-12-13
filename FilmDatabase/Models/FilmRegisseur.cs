using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
	
		[Table("FilmRegisseur")]
		public class FilmRegisseur
		{

			[Key]
			public int FilmRegisseurId { get; set; }
			[Required]
			public int FilmId { get; set; }
			[Required]
			public int RegisseurId { get; set; }

			//Navigation Properties
			[Required]
			public Regisseur Regisseurs { get; set; }
			[Required]
			public Film Films { get; set; }
		}
}
