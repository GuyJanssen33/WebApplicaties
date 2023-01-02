using FilmDatabase.Data;
using FilmDatabase.Data.UnitOfWork;
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
		private readonly IUnitOfWork _uow;

		public DetailsController(FilmdatabaseDbContext context, IUnitOfWork uow)
		{
			_context = context;
			_uow = uow;
		}

		public IActionResult AanpassenSamenvatting(int id)
			{
			Film film = _uow.FilmRepository.GetById(id);
			FilmAanpassenViewModel vm = new FilmAanpassenViewModel()
			{
				FilmId = film.FilmId,
				Titel = film.Titel,
				Genre = film.Genre,
				Lengte = film.Lengte,
				Schrijver = film.Schrijver,
				Samenvatting = film.Samenvatting,
				ReleaseDatum = film.ReleaseDatum,
				Verdeler = film.Verdeler,
				Rating = film.Rating,
				Poster = film.Poster,
			};
			return View(vm);
		}

		public IActionResult Index(int id)
		{
			Film film = _uow.FilmRepository.GetById(id);

			DetailsViewModel vm = new DetailsViewModel()
			{
				FilmId = film.FilmId,
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

			//DetailsViewModel vmd = new DetailsViewModel()
			//{
			//	FilmId = film.FilmId,
			//	Titel = film.Titel,
			//	Genre = film.Genre,
			//	Lengte = film.Lengte,
			//	Schrijver = film.Schrijver,
			//	Samenvatting = film.Samenvatting,
			//	ReleaseDatum = film.ReleaseDatum,
			//	Verdeler = film.Verdeler,
			//	Rating = film.Rating,
			//	Poster = film.Poster,
			//};

			if ((vm.Acteurs.Count <= 0) || (vm.Producenten.Count <= 0) || (vm.Regisseurs.Count <= 0))
			{
				return View(vm);
			}
			else
			{
				return View(vm);
			}

			


		}

		public IActionResult UpdateFilm(Film filmf)
		{
			
			_uow.FilmRepository.Update(filmf);
			_uow.Save();

			return RedirectToAction("Index", "Home", new {area = ""});
		}

		public IActionResult DeleteFilm(int id)
		{
			
			Film film = _uow.FilmRepository.GetById(id);
			_uow.FilmRepository.Delete(film);
			_uow.Save();


			return RedirectToAction("Index", "Home", new { area = "" });
		}
	}
}
