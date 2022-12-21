using System;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.ViewModels
{
	public class CreateGebruikerViewModel
	{
		public string Voornaam { get; set; }

		public string Familienaam { get; set; }

		public DateTime Geboortedatum { get; set; }

		public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
