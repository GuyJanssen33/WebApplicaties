namespace FilmDatabase.Models
{
	public class FilmRegisseur
	{
		public int FilmRegisseurId { get; set; }
		public int FilmId { get; set; }
		public int RegisseurId { get; set; }

		public Film Film { get; set; }
		public Regisseur Regisseur { get; set; }
	}
}
