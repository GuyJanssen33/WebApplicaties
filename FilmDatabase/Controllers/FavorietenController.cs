using Microsoft.AspNetCore.Mvc;

namespace FilmDatabase.Controllers
{
	public class FavorietenController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
