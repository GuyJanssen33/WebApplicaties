using FilmDatabase.Data;
using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
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



		public IActionResult Index(int id)
		{
			try
			{
				if (id != 0)
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
					if ((vm.Acteurs.Count <= 0) || (vm.Producenten.Count <= 0) || (vm.Regisseurs.Count <= 0))
					{
						return View(vm);
					}
					else
					{
						return View(vm);
					}
				}
				else
				{
					throw new System.Exception("U dient eerst een film te selecteren");
				}

			}
			catch (System.Exception)
			{

				throw new System.Exception("Er is iets fout gegaan, U dient eerst een film rte selecteren ");
			}


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


			//return View(vm);



		}


		[Authorize(Roles = "user")]

		public IActionResult AanpassenSamenvatting(int id)
		{
			try
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
			catch (System.Exception)
			{

				throw new System.Exception("U dient eerst een film te selecteren");
			}

		}

		[Authorize(Roles = "admin")]
		public IActionResult EditFilm(int id)
		{
			try
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
			catch (System.Exception)
			{

				throw new System.Exception("U dient eerst een film te selecteren");
			}

		}

		[HttpPost]
		public IActionResult UpdateFilm(Film filmf)
		{
			try
			{
				_uow.FilmRepository.Update(filmf);
				_uow.Save();

				return RedirectToAction("Index", "Home", new { area = "" });
			}
			catch (System.Exception)
			{

				throw new System.Exception("U dient eerst een film te selecteren");
			}


		}


		[Authorize(Roles = "admin")]
		public IActionResult DeleteFilm(int id)
		{
			

			Film film = _uow.FilmRepository.GetById(id);
			_uow.FilmRepository.Delete(film);
			_uow.Save();


			return RedirectToAction("Index", "Home", new { area = "" });
		}

		[HttpGet]
		public IActionResult ZoekOpNaam(string titel)
		{
			Film film = _uow.FilmRepository.GetByTitle(titel);

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

				Acteurs = _context.Acteur.Where(a => a.FilmActeurs.Any(fa => fa.FilmId == film.FilmId)).ToList(),
				Regisseurs = _context.Regisseur.Where(r => r.FilmRegisseurs.Any(fr => fr.FilmId == film.FilmId)).ToList(),
				Producenten = _context.Producent.Where(p => p.FilmProducenten.Any(fp => fp.FilmId == film.FilmId)).ToList(),
			};



			if ((vm.Acteurs.Count <= 0) || (vm.Producenten.Count <= 0) || (vm.Regisseurs.Count <= 0))
			{
				return View(vm);
			}
			else
			{
				return View(vm);
			}
			//return View(vm);



		}
	}
}
