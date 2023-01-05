using FilmDatabase.Data;
using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly FilmdatabaseDbContext _context;
		private readonly IUnitOfWork _uow;

		public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
		{
			_logger = logger;
			_uow = uow;
		}



		public IActionResult Index()

		{
			try
			{
				FilmListViewModel vm = new FilmListViewModel();

				vm.Films = _uow.FilmRepository.GetAll().ToList();

				return View(vm);
			}
			catch (Exception)
			{

				throw new Exception("Er is iets misgegaan bij het laden van de site, probeer later opnieuw");
			}

		}




		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
