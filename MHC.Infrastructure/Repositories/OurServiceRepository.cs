using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MHC.Infrastructure.Repositories
{
    public class OurServiceRepository : GenericRepository<OurService>, IOurServiceRepository
    {
        private readonly DBC _context;
        public OurServiceRepository(DBC dbc) : base(dbc) => _context = dbc;

        public async Task<List<OurService>> GetAllIncludeAsync()
        {
            return await _context.OurServices
                .Include(s => s.Category)
                .ToListAsync();
        }
    }
}
