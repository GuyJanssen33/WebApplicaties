using FilmDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.ViewModels
{
    public class DetailsViewModel
    {
		public int FilmId { get; set; }
		public string Titel { get; set; }
        public string Genre { get; set; }
        public string Lengte { get; set; }
        public string Schrijver { get; set; }
        public string Samenvatting { get; set; }
		[BindProperty, DataType(DataType.Date)]
		public DateTime? ReleaseDatum { get; set; }
        public string Verdeler { get; set; }
        public string? Rating { get; set; }
        public string? Poster { get; set; }

		public List<Film> Films { get; set; }
		public List<Acteur> Acteurs { get; set; }
		public List<Regisseur> Regisseurs { get; set; }
		public List<Producent> Producenten { get; set; }
		public List<FilmActeur> FilmActeurs { get; set; }
		public List<FilmRegisseur> FilmRegisseurs { get; set; }
		public List<FilmProducent> FilmProducenten { get; set; }


	}

		
		
}
