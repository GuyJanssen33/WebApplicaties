using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilmDatabase.ViewModels
{
	public class GrantPermissionsViewModel
	{
		public SelectList Gebruikers { get; set; }
		public SelectList Rollen { get; set; }
		public string GebruikerId { get; set; }
		public string RolId { get; set; }
	}
}
