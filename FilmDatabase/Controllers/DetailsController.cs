using Microsoft.AspNetCore.Mvc;

namespace FilmDatabase.Controllers
{
	public class DetailsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
