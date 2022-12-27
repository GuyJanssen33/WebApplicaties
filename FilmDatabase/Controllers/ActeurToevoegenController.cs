using Microsoft.AspNetCore.Mvc;
using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using FilmDatabase.Data;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FilmDatabase.Controllers
{
	public class ActeurToevoegenController : Controller
	{
		private readonly ILogger<ActeurToevoegenController> _logger;

		private readonly IUnitOfWork _uow;



		public ActeurToevoegenController(ILogger<ActeurToevoegenController> logger, IUnitOfWork uow)
		{
			_logger = logger;
			_uow = uow;
		}

		public IActionResult Index()

		{
			ActeurToevoegenViewModel vm = new ActeurToevoegenViewModel();

			return View(vm);
		}

		[HttpPost]
		public async Task<ActionResult<Acteur>> AddActeur(Acteur Acteura, FilmActeur filmActeura)
		{ 
			FilmActeur acteurFilm = new FilmActeur();
			_uow.ActeurRepository.Create(Acteura);
			await _uow.Save();
			List<Film> films = _uow.FilmRepository.GetAll().ToList();
			Film film = films.Last();
			List<Acteur> acteurs = _uow.ActeurRepository.GetAll().ToList();
			Acteur acteur = acteurs.Last();
			acteurFilm.Personage = filmActeura.Personage;
			acteurFilm.FilmId = film.FilmId;
			acteurFilm.ActeurId = acteur.ActeurId;
			_uow.FilmActeurRepository.Create(acteurFilm);
			await _uow.Save();
			return RedirectToAction("Index", "ProducentToevoegen", new { area = "" });
		}

	}
}
