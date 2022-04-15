using WEBAPI.Data;
using WEBAPI.Services;

namespace WEBAPI.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly RepoSeyfullahDBContext _context;  
                          
        private readonly ILogger _logger;

        public IPersonelRepository Personel { get; private set; }

        public UnitOfWork(RepoSeyfullahDBContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            
            _logger = loggerFactory.CreateLogger("logs");
            Personel = new PersonelRepository(context, _logger);
        }

        //public IPersonelRepository Personel => throw new NotImplementedException();

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
