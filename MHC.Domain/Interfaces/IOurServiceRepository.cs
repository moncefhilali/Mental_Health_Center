using MHC.Domain.Entities;

namespace MHC.Domain.Interfaces
{
    public interface IOurServiceRepository : IGenericRepository<OurService>
    {
        Task<List<OurService>> GetAllIncludeServices();
    }
}
