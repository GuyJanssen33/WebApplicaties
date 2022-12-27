using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase.Controllers
{
	public class RegisseurToevoegenController : Controller
	{

		private readonly ILogger<RegisseurToevoegenController> _logger;

		private readonly IUnitOfWork _uow;



		public RegisseurToevoegenController(ILogger<RegisseurToevoegenController> logger, IUnitOfWork uow)
		{
			_logger = logger;
			_uow = uow;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult<Regisseur>> AddRegisseur(Regisseur Regisseura, FilmProducent filmProducenta)
		{
			FilmRegisseur regisseurFilm = new FilmRegisseur();
			_uow.RegisseurRepository.Create(Regisseura);
			await _uow.Save();
			List<Film> films = _uow.FilmRepository.GetAll().ToList();
			Film film = films.Last();
			List<Regisseur> regisseurs = _uow.RegisseurRepository.GetAll().ToList();
			Regisseur regisseur = regisseurs.Last();

			regisseurFilm.FilmId = film.FilmId;
			regisseurFilm.RegisseurId = regisseur.RegisseurId;
			_uow.FilmRegisseurRepository.Create(regisseurFilm);
			await _uow.Save();
			return RedirectToAction("Index", "Home", new { area = "" });
		}
	}
}