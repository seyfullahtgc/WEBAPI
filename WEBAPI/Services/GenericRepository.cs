using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WEBAPI.Data;

namespace WEBAPI.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly RepoSeyfullahDBContext _context;  //database
        protected readonly DbSet<T> _dbSet;                  //T nin databasedeki tablo karşılığı
        protected readonly ILogger _logger;
        public GenericRepository(RepoSeyfullahDBContext context, ILogger logger)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            _logger = logger;
        }

        public virtual async Task<bool> Ekle(T entity)  //entitynin databasedeki tablo karşılığı
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<T> GetirById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetirFiltreli(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetirHepsi()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<bool> Güncelle(T entity)
        {
            _dbSet.Update(entity);
            return true;
        }

        public virtual async Task<bool> Sil(Guid id)
        {
            _dbSet.Remove(await _dbSet.FindAsync(id));
            return true;
        }
    }
}
