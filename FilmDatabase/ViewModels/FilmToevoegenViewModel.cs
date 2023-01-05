using FilmDatabase.Models;
using System;
using System.Collections.Generic;

namespace FilmDatabase.ViewModels
{
	public class FilmToevoegenViewModel
	{
		//public Film Filmf { get; set; }

		
		public string Titel { get; set; }
		public string Genre { get; set; }
		public string Lengte { get; set; }
		public string Schrijver{ get; set; }
		public string Samenvatting { get; set; }
		public string Date { get; set; }
		public DateTime ReleaseDatum { get; set; }
		public string Verdeler { get; set; }
		public string Rating { get; set; }
		public string Poster { get; set; }
	}
}
