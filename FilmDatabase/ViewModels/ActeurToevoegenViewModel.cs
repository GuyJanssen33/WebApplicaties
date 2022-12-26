using FilmDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.ViewModels
{
	public class ActeurToevoegenViewModel
	{
		public Acteur Acteura { get; set; }
		public string Voornaam { get; set; }
		public string Familienaam { get; set; }
		[BindProperty, DataType(DataType.Date)]
		public DateTime GeboorteDatum { get; set; }
		public string GeboortePlaats { get; set; }
		public string GeboorteLand { get; set; }

		public List<Film> Films { get; set; }
		public FilmActeur FilmActeura { get; set; }
	}
}
