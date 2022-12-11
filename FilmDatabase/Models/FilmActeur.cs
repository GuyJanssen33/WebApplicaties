namespace FilmDatabase.Models
{
	public class FilmActeur
	{
		public int FilmActeurId { get; set; }
		public int FilmId { get; set; }
		public int ActeurId { get; set; }
		public string Personage { get; set; }



		public Film Film { get; set; }
		public Acteur Acteur { get; set; }
	}
}
