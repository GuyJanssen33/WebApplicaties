using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
	
		[Table("Regisseur")]
		public class Regisseur
		{
			[Key]
			public int RegisseurId { get; set; }

			public string? Voornaam { get; set; }

			public string? Familienaam { get; set; }

			public DateTime? GeboorteDatum { get; set; }

			public string? GeboortePlaats { get; set; }

			public string? GeboorteLand { get; set; }

			//Navigation properties

			public List<FilmRegisseur> FilmRegisseurs { get; set; }
		}
	
}
