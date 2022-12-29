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
			//var ingelogdeUserId = await _userManager.GetUserIdAsync(User);
			var userid = user.Id.ToString();
			FavorietenListViewModel vm = new FavorietenListViewModel();
			vm.Favorieten = _uow.FavorietRepository.GetAll().Include(x => x.Films).Where( x => x.CustomUserId == userid).ToList();

			if (vm.Favorieten.Count == 0)
			{
				Film film = _uow.FilmRepository.GetById(id);
				Favoriet favoriet = new Favoriet();
				favoriet.FilmId = film.FilmId;
				favoriet.CustomUserId = userid;
				vm.Favorieten.Add(favoriet);

				return View(vm);
			}
			else
			{
				
				return View(vm);
			}
			return View();
		}
		
	}
}
