using FilmDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.ViewModels
{
    public class ZoekOpNaamViewModel
    {
        public List<Film> Films { get; set; }
		//public Film Film { get; set; }
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
	}
}
