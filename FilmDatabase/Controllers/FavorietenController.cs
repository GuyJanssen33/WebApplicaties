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

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var favorieten = _uow.FavorietRepository.GetAll().Include(x => x.Films).Where(x => x.CustomUserId == user.Id).ToList();
            FavorietenListViewModel favorietenListViewModel = new FavorietenListViewModel();
            favorietenListViewModel.Favorieten = favorieten;
            favorietenListViewModel.User = user;
            return View(favorietenListViewModel);
        }
		
        public async Task<IActionResult> AddFAvoriet(int id)
		{
			var user = await _userManager.GetUserAsync(HttpContext.User);
			
			
			var userid = user.Id.ToString();
			FavorietenListViewModel vm = new FavorietenListViewModel();
			vm.Favorieten = _uow.FavorietRepository.GetAll().Include(x => x.Films).Where( x => x.CustomUserId == userid).ToList();
			vm.User = user;
			if (vm.Favorieten.Count == 0)
			{
				Film film = _uow.FilmRepository.GetById(id);
				Favoriet favoriet = new Favoriet();
				vm.Favorieten = new List<Favoriet>();
				
				favoriet.FilmId = film.FilmId;
				favoriet.CustomUserId = userid;
				_uow.FavorietRepository.Create(favoriet);
				vm.Favorieten.Add(favoriet);
				await _uow.Save();

				return View(vm);
			}
			else
			{
				Film film = _uow.FilmRepository.GetById(id);
				
				foreach (var item in vm.Favorieten)
				{
					if (item.FilmId == film.FilmId)
					{
						return View(vm);
					}
					else
					{
						Favoriet favoriet = new Favoriet();
						favoriet.FilmId = film.FilmId;
						favoriet.CustomUserId = userid;
						_uow.FavorietRepository.Create(favoriet);
						vm.Favorieten.Add(favoriet);
						await _uow.Save();
						return View(vm);
					}
				}
				
				return View(vm);
			}
			
		}
		
	}
}
