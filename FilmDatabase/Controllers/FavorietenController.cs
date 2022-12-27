using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.Data;
using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;


namespace FilmDatabase.Controllers
{
	public class FavorietenController : Controller
	{
		private readonly IUnitOfWork _uow;
		private readonly UserManager<CustomUser> _userManager;

		public FavorietenController(IUnitOfWork uow, UserManager<CustomUser> userManager)
		{
			_uow = uow;
			_userManager = userManager;
			List<Favoriet> favorieten = _uow.FavorietRepository.GetAll().Include(x => x.Films).ToList();
		}

		
		public async Task<IActionResult> Index(int id)
		{
			var user = await _userManager.GetUserAsync(HttpContext.User);
			//var ingelogdeUserId = await _userManager.FindByIdAsync(User.Identity.Name);
			
			var UserId = int.Parse(User.Id);
			var favorieten = _uow.FavorietRepository.GetAll().Include(x => x.Films).Where(x => x.CustomUserId ==UserId).ToList();

			return View();
		}
		
	}
}
