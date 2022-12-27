using FilmDatabase.Data.Repository;
using FilmDatabase.Models;
using System.Threading.Tasks;

namespace FilmDatabase.Data.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly FilmdatabaseDbContext _context;
		private IGenericRepository<Film> filmrepository;
		private IGenericRepository<Acteur> acteurrepository;
		private IGenericRepository<Producent> producentrepository;
		private IGenericRepository<Regisseur> regisseurrepository;
		private IGenericRepository<FilmActeur> filmActeurrepository;
		private IGenericRepository<FilmProducent> filmProducentrepository;
		private IGenericRepository<FilmRegisseur> filmRegisseurepository;
		private IGenericRepository<Favoriet> favorietrepository;

		public UnitOfWork(FilmdatabaseDbContext context)
		{
			_context = context;
		}
		
		

		public IGenericRepository<Film> FilmRepository
		{
			get
			{
				if (this.filmrepository == null)
				{
					this.filmrepository = new GenericRepository<Film>(_context);
				}
				return filmrepository;
			}					
		}

		public IGenericRepository<Regisseur> RegisseurRepository
		{
			get
			{
				if (this.regisseurrepository == null)
				{
					this.regisseurrepository = new GenericRepository<Regisseur>(_context);
				}

				return regisseurrepository;
			}
		}

		public IGenericRepository<Acteur> ActeurRepository
		{
			get
			{
				if (this.acteurrepository == null)
				{
					this.acteurrepository = new GenericRepository<Acteur>(_context);
				}

				return acteurrepository;
			}
		}
		
		public IGenericRepository<FilmActeur> FilmActeurRepository
		{
			get
			{
				if (this.filmActeurrepository == null)
				{
					this.filmActeurrepository = new GenericRepository<FilmActeur>(_context);
				}

				return filmActeurrepository;
			}
		}

		public IGenericRepository<FilmRegisseur> FilmRegisseurRepository
		{
			get
			{
				if (this.filmRegisseurepository == null)
				{
					this.filmRegisseurepository = new GenericRepository<FilmRegisseur>(_context);
				}

				return filmRegisseurepository;
			}
		}
		 

		public IGenericRepository<FilmProducent> FilmProducentRepository
		{
			get
			{
				if (this.filmProducentrepository == null)
				{
					this.filmProducentrepository = new GenericRepository<FilmProducent>(_context);
				}

				return filmProducentrepository;
			}
		}

		public IGenericRepository<Producent> ProducentRepository
		{
			get
			{
				if (this.producentrepository == null)
				{
					this.producentrepository = new GenericRepository<Producent>(_context);
				}
				
				return producentrepository;
			}
		}

		public IGenericRepository<Favoriet> FavorietRepository
		{
			get
			{
				if (this.favorietrepository == null)
				{
					this.favorietrepository = new GenericRepository<Favoriet>(_context);
				}

				return favorietrepository;
			}
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}
	}
}
