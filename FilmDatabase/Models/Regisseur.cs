using System.Collections.Generic;

namespace FilmDatabase.Models
{
	public class Regisseur
	{
		public int RegisseurId { get; set; }
		public string Voornaam { get; set; }
		public string Achternaam { get; set; }
		public string GeboorteDatum { get; set; }
		public string GeboortePlaats { get; set; }
		public string GeboorteLand { get; set; }


		public List<FilmRegisseur> FilmRegisseurs { get; set; }
	}
}
