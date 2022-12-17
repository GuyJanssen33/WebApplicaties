using FilmDatabase.Data;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FilmDatabase.Controllers
{
	public class DetailsController : Controller
	{
		private readonly FilmdatabaseDbContext _context;

		public DetailsController(FilmdatabaseDbContext context)
		{
			_context = context;
		}

		public IActionResult Index(int id)
		{
			Film film =  _context.Film.Where(f => f.FilmId == id).FirstOrDefault();

			DetailsViewModel vm = new DetailsViewModel()
			{
				Titel = film.Titel,
				Genre = film.Genre,
				Lengte = film.Lengte,
				Schrijver = film.Schrijver,
				Samenvatting = film.Samenvatting,
				ReleaseDatum = film.ReleaseDatum,
				Verdeler = film.Verdeler,
				Rating = film.Rating,
				Poster = film.Poster,
				Acteurs = _context.Acteur.Where(a => a.FilmActeurs.Any(fa => fa.FilmId == id)).ToList(),
				Regisseurs = _context.Regisseur.Where(r => r.FilmRegisseurs.Any(fr => fr.FilmId == id)).ToList(),
				Producenten = _context.Producent.Where(p => p.FilmProducenten.Any(fp => fp.FilmId == id)).ToList(),
			};

			return View(vm);
		}
	}
}
