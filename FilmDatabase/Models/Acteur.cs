using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
	public class Acteur
	{
		
		[Key]
		public int ActeurId { get; set; }

		public string? Voornaam { get; set; }

		public string? Familienaam { get; set; }

		public DateTime? GeboorteDatum { get; set; }

		public string? GeboortePlaats { get; set; }

		public string? GeboorteLand { get; set; }

		//Navigation properties
		public List<FilmActeur> FilmActeurs { get; set; }
	}
}
