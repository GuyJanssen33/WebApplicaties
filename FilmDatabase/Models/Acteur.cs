using System.Collections.Generic;

namespace FilmDatabase.Models
{
	public class Acteur
	{
		public int ActeurId { get; set; }
		public string Voornaam { get; set; }
		public string Achternaam { get; set; }
		public string GeboorteDatum { get; set; }
		public string GeboortePlaats { get; set; }
		public string GeboorteLand { get; set; }


		public List<FilmActeur> FilmActeurs { get; set; }
	}
}
