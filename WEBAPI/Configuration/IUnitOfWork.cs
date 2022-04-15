using WEBAPI.Services;

namespace WEBAPI.Configuration
{
    public interface IUnitOfWork
    {
        IPersonelRepository Personel { get; }   //
        Task CompleteAsync();     //herşeyi veritabanına güncelliyor.
        void Dispose();           //belli süre gereksiz çalışan şeyleri siler ramden.
    }
}
