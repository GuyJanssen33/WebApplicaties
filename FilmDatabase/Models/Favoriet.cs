namespace FilmDatabase.Models
{
	public class Favoriet
	{
		public int FavorietId { get; set; }
		public int FilmId { get; set; }
		public int GebruikerId { get; set; }

		public Film Film { get; set; }
		public Gebruiker Gebruiker { get; set; }
	}
}
