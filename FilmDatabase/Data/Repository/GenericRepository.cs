using Microsoft.Net.Http.Headers;
using System.Linq;

namespace FilmDatabase.Data.Repository
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private readonly FilmdatabaseDbContext _context;

		public GenericRepository(FilmdatabaseDbContext context)
		{
			_context = context;
		}

		public void Create(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
		}

		public void Delete(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
		}

		public IQueryable<TEntity> GetAll()
		{
			return _context.Set<TEntity>();
		}

		public TEntity GetById(int id)
		{
			return _context.Set<TEntity>().Find(id);
		}

		public TEntity GetLastEntry()
		{
			return _context.Set<TEntity>().OrderByDescending(x => x).FirstOrDefault();
		}

		

		public void Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);
		}
	}
}
