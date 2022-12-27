using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.Models;
using System.Collections.Generic;

namespace FilmDatabase.ViewModels
{
	public class FavorietenListViewModel
	{
		public List<Favoriet> Favorieten { get; set; }

		public CustomUser User { get; set; }


	}
}
