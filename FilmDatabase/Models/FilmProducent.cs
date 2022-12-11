namespace FilmDatabase.Models
{
	public class FilmProducent
	{
		public int FilmProducentId { get; set; }
		public int FilmId { get; set; }
		public int ProducentId { get; set; }

		public Film Film { get; set; }
		public Producent Producent { get; set; }
	}
}
