using FilmDatabase.Models;
using System.Collections.Generic;
using System;

namespace FilmDatabase.ViewModels
{
	public class FavorietenViewModel
	{
		public string Titel { get; set; }
		public string Genre { get; set; }
		public string Lengte { get; set; }
		public string Schrijver { get; set; }
		public string Samenvatting { get; set; }
		public DateTime? ReleaseDatum { get; set; }
		public string Verdeler { get; set; }
		public string? Rating { get; set; }
		public string? Poster { get; set; }

		public List<Favoriet> Favorieten { get; set; }
		public List<Film> Films { get; set; }
		public Film Filmp { get; set; }
		public List<Acteur> Acteurs { get; set; }
		public List<Regisseur> Regisseurs { get; set; }
		public List<Producent> Producenten { get; set; }
		public List<FilmActeur> FilmActeurs { get; set; }
		public List<FilmRegisseur> FilmRegisseurs { get; set; }
		public List<FilmProducent> FilmProducenten { get; set; }



	}
}
