using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase.Controllers
{
	public class ProducentToevoegenController : Controller
	{

		private readonly ILogger<ActeurToevoegenController> _logger;

		private readonly IUnitOfWork _uow;

		public ProducentToevoegenController(ILogger<ActeurToevoegenController> logger, IUnitOfWork uow)
		{
			_logger = logger;
			_uow = uow;
		}


		public IActionResult Index()
		{
			return View();
		}

		//public IActionResult Index(int id)
		//{
		//	return View();
		//}

		[HttpPost]
		public async Task<ActionResult<Producent>> AddProducent(Producent Producenta, FilmProducent filmProducenta, int id)
		{
			FilmProducent producentFilm = new FilmProducent();
			_uow.ProducentRepository.Create(Producenta);
			await _uow.Save();
			List<Film> films = _uow.FilmRepository.GetAll().ToList();
			Film film = films.Last();
			List<Producent> producenten = _uow.ProducentRepository.GetAll().ToList();
			Producent producent = producenten.Last();

			producentFilm.FilmId = film.FilmId;
			producentFilm.ProducentId = producent.ProducentId;
			_uow.FilmProducentRepository.Create(producentFilm);
			await _uow.Save();
			return RedirectToAction("Index", "Home", new { area = "" });
		}
	}
}