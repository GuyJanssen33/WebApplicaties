using FilmDatabase.Data.Repository;
using FilmDatabase.Models;
using System.Threading.Tasks;

namespace FilmDatabase.Data.UnitOfWork
{
	public interface IUnitOfWork
	{
		IGenericRepository<Film> FilmRepository { get; }
		IGenericRepository<Regisseur> RegisseurRepository { get; }
		IGenericRepository<Acteur> ActeurRepository { get; }
		IGenericRepository<FilmActeur> FilmActeurRepository { get; }
		IGenericRepository<FilmRegisseur> FilmRegisseurRepository { get; }
		IGenericRepository<FilmProducent> FilmProducentRepository { get; }
		IGenericRepository<Producent> ProducentRepository { get; }
		IGenericRepository<Favoriet> FavorietRepository { get; }



		Task Save();
	}
}
