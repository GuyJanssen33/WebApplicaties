using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;

using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase.Controllers
{
	public class FilmToevoegenController : Controller
	{

		private readonly IUnitOfWork _uow;
		private readonly ILogger<FilmToevoegenController> _logger;


		public FilmToevoegenController(ILogger<FilmToevoegenController> logger, IUnitOfWork uow)
		{
			_logger = logger;
			_uow = uow;
			 
		}

		public IActionResult Index()
		{


			return View();
		}


		public IActionResult ActeurToevoegen()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult<Film>>AddFilm(Film Filmf)
		{
			_uow.FilmRepository.Create(Filmf);
			await _uow.Save();
			//return RedirectToAction("ActeurToevoegen.cshtml");
			return RedirectToAction("Index", "ActeurToevoegen", new { area = "" });

			//return View();
		}
	}
}
