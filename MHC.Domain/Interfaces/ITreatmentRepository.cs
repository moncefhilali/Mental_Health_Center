using MHC.Domain.Entities;

namespace MHC.Domain.Interfaces
{
    public interface ITreatmentRepository : IGenericRepository<Treatment>
    {
        Task<List<Treatment>> GetAllIncludeAsync();
    }
}
