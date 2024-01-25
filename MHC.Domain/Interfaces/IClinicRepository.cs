using MHC.Domain.Entities;

namespace MHC.Domain.Interfaces
{
    public interface IClinicRepository : IGenericRepository<Clinic>
    {
        Task<List<Clinic>> GetAllIncludeAsync();
    }
}
