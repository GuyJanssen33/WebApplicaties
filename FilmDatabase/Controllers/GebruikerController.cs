using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase.Controllers
{
	[Authorize(Roles ="admin")]
	public class GebruikerController : Controller
	{
		private UserManager<CustomUser> _userManager;
		private RoleManager<IdentityRole> _roleManager;

		public GebruikerController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
		}
		


		public IActionResult Index()
		{
			GebruikerListViewModel vm = new GebruikerListViewModel()
			{
				Gebruikers = _userManager.Users.ToList()
			};
			return View(vm);
		}

		public IActionResult Details (string id)
		{
			CustomUser gebruiker = _userManager.Users.Where(k => k.Id == id).FirstOrDefault();
			if (gebruiker != null)
			{
				GebruikerDetailsViewModel vm = new GebruikerDetailsViewModel()
				{

					Id = gebruiker.Id,
					Voornaam = gebruiker.Voornaam,
					Familienaam = gebruiker.Familienaam,
					Geboortedatum = gebruiker.Geboortedatum.Value

				};

				return View(vm);
					
			} else
			{
				GebruikerListViewModel vm = new GebruikerListViewModel()
				{
					Gebruikers = _userManager.Users.ToList()
				};
				return View("Index", vm);
			}
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreateGebruikerViewModel vm)
		{
			if (ModelState.IsValid)
			{
				CustomUser gebruiker = new CustomUser()
				{
					UserName = vm.Email,
					Voornaam = vm.Voornaam,
					Familienaam = vm.Familienaam,
					Geboortedatum = vm.Geboortedatum,
					Email = vm.Email
				};

				IdentityResult result = await _userManager.CreateAsync(gebruiker, vm.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					foreach (IdentityError error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}
			return View(vm);
		}

		public IActionResult GrantPermissions()
		{
			GrantPermissionsViewModel vm = new GrantPermissionsViewModel()
			{
				Gebruikers = new SelectList( _userManager.Users.ToList(), "Id", "UserName"),
				Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
			};
			return View(vm);
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GrantPermissions(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                else
                    ModelState.AddModelError("", "User or role Not Found");
            }
            return View(viewModel);
        }

        [HttpPost]
		public async Task<IActionResult> Delete(string id)
		{
			CustomUser gebruiker = await _userManager.FindByIdAsync(id);
			if (gebruiker != null)
			{
				IdentityResult result = await _userManager.DeleteAsync(gebruiker);
				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					foreach (IdentityError error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}
			else 
			{
				ModelState.AddModelError("", "Gebruiker niet gevonden");
			}
			return RedirectToAction("Index");
		}
	}
}
