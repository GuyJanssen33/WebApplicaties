using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.Data;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Collections.Generic;
using System.Linq;

namespace FilmDatabase.Controllers
{
	public class FavorietenController : Controller
	{
		private readonly FilmdatabaseDbContext _context;

		public FavorietenController(FilmdatabaseDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

	}
}
