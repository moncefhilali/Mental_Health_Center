using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DBC context) : base(context) { }
    }
}
