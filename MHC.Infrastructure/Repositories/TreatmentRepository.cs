using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MHC.Infrastructure.Repositories
{
    public class TreatmentRepository : GenericRepository<Treatment>, ITreatmentRepository
    {
        private readonly DBC _context;
        public TreatmentRepository(DBC context) : base(context) => _context = context;

        public async Task<List<Treatment>> GetAllIncludeAsync()
        {
            return await _context.Treatments
                .Include(t => t.Doctor)
                    .ThenInclude(d => d.Image)
                .Include(t => t.Image)
                .ToListAsync();
        }
    }
}
