using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
	
	public class Film
	{
		[Key]
		public int FilmId { get; set; }

		[Required]
		public string Titel { get; set; }

		[Required]
		public string Genre { get; set; }

		[Required]
		public string Lengte { get; set; }

		[Required]
		public string Schrijver { get; set; }

		public string? Samenvatting { get; set; }


		public DateTime? ReleaseDatum { get; set; }

		[Required]
		public string Verdeler { get; set; }

		public string? Rating { get; set; }

		public string? Poster { get; set; }


		//Navigation Properties

		public List<FilmActeur> FilmActeurs { get; set; }
		public List<FilmRegisseur> FilmRegisseurs { get; set; }
		public List<Favoriet> Favorieten { get; set; }
		public List<FilmProducent> FilmProducenten { get; set; }
	}
}
