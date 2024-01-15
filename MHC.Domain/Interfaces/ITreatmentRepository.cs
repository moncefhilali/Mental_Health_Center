using MHC.Domain.Entities;

namespace MHC.Domain.Interfaces
{
    public interface ITreatmentRepository : IGenericRepository<Treatment>
    {
        Task<IEnumerable<Treatment>> GetAllIncludeAsync();
    }
}
