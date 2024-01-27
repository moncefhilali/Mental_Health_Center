using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MHC.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly DBC _context;
        public CategoryRepository(DBC context) : base(context) => _context = context;

        public async Task<List<Category>> GetAllIncludeAsync()
        {
            return await _context.Categories
                .Include(c => c.Services)
                .ToListAsync();
        }
    }
}
