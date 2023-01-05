using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Data;
using FilmDatabase.Models;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FilmDatabase.Controllers
{
    public class ZoekOpNaamController : Controller
    {
       
        private readonly IUnitOfWork _uow;


		public ZoekOpNaamController(FilmdatabaseDbContext context, IUnitOfWork uow)
		{
			
			_uow = uow;
		}

		[HttpGet]
        public IActionResult ZoekOpNaam(string titel)
        {


            ZoekOpNaamViewModel vm = new ZoekOpNaamViewModel();

            vm.Films = _uow.FilmRepository.GetAll().ToList();
			var titelU = titel.ToUpper();
            foreach (var film in vm.Films)
                {
				//film.Titel.ToLower();
                if (film.Titel == titelU)
                {
					vm.FilmId = film.FilmId;
					vm.Titel = film.Titel;
					vm.Genre = film.Genre;
					vm.Lengte = film.Lengte;
					vm.Schrijver = film.Schrijver;
					vm.Samenvatting = film.Samenvatting;
					vm.ReleaseDatum = film.ReleaseDatum;
					vm.Verdeler = film.Verdeler;
					vm.Rating = film.Rating;
					vm.Poster = film.Poster;
					
				}
             }
            return View(vm);

        }
    }
}
