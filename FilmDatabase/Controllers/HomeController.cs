using FilmDatabase.Data;
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

		public HomeController(ILogger<HomeController> logger, FilmdatabaseDbContext context)
		{
			_logger = logger;
			_context = context;
		}
		

		public IActionResult Index()
			
		{
			FilmListViewModel vm = new FilmListViewModel()
			{
				Films = _context.Film.ToList()
			};
			return View(vm);
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
