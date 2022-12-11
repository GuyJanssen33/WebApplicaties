using System.Collections.Generic;

namespace FilmDatabase.Models
{
	public class Gebruiker
	{
		public int GebruikerId { get; set; }
		public string Geslacht { get; set; }

		
		public List<Favoriet> favoriet { get; set; }


	}
}
