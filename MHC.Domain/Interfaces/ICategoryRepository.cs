using MHC.Domain.Entities;

namespace MHC.Domain.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<List<Category>> GetAllIncludeAsync();
    }
}
