using System;

namespace FilmDatabase.ViewModels
{
	public class ProducentToevoegenViewModel
	{
		public string Voornaam { get; set; }
		public string Familienaam { get; set; }
		public string GeboortePlaats { get; set; }
		public string GeboorteLand { get; set; }
		public DateTime GeboorteDatum { get; set; }

		public int FilmId { get; set; }
	}
}
