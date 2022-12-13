using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
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
