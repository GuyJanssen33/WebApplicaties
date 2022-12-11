using System;
using System.Collections.Generic;

namespace FilmDatabase.Models
{
	
	public class Film
	{
		public int FilmId { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }
		public string Lengte { get; set; }
		public string Schrijver { get; set; }
		public string Omschrijving { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Verdeler { get; set; }
		public string Rating { get; set; }
		public string Poster { get; set; }

		public List<FilmActeur> FilmActeurs { get; set; }
		public List<FilmRegisseur> FilmRegisseurs { get; set; }
		public List<FilmProducent> FilmProducenten { get; set; }
		public List<Favoriet> Favorieten { get; set; }
	}
}
