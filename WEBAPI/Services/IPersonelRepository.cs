using WEBAPI.Model;

namespace WEBAPI.Services
{
    public interface IPersonelRepository : IGenericRepository<Personel>
    {
        Task<Personel> KayıplarıGetir();




    }
}
