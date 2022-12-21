using System;

namespace FilmDatabase.ViewModels
{
	public class GebruikerDetailsViewModel
	{
		public string Id { get; set; }

		public string Voornaam { get; set; }
		public string Familienaam { get; set; }

		public string UserName { get; set; }

		public DateTime Geboortedatum { get; set; }
	}
}
