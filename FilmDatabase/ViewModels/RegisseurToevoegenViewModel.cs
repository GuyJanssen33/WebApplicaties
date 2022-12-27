using System;

namespace FilmDatabase.ViewModels
{
	public class RegisseurToevoegenViewModel
	{
		public int RegisseurId { get; set; }

		public string? Voornaam { get; set; }

		public string? Familienaam { get; set; }

		public DateTime? GeboorteDatum { get; set; }

		public string? GeboortePlaats { get; set; }

		public string? GeboorteLand { get; set; }
	}
}
