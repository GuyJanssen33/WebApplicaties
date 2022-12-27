using System.Linq;

namespace FilmDatabase.Data.Repository
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> GetAll();
		TEntity GetById(int id);
		TEntity GetLastEntry();
		void Create(TEntity entity);
		void Update(TEntity entity);
		void Delete(TEntity entity);
		//void Save();
	}
}
