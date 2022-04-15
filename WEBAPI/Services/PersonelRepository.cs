using Microsoft.EntityFrameworkCore;
using WEBAPI.Data;
using WEBAPI.Model;

namespace WEBAPI.Services
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(RepoSeyfullahDBContext context, ILogger _logger) : base(context,_logger)
        {
            DbSet<Personel> _dbset = _context.Set<Personel>();

        }

        public override async Task<IEnumerable<Personel>> GetirHepsi()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Hatalar :",typeof(PersonelRepository));
                return new List<Personel>();
            }
        }

        public Task<Personel> KayıplarıGetir()
        {
            throw new NotImplementedException();
        }
    }
}
