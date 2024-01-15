using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class TreatmentRepository : GenericRepository<Treatment>, ITreatmentRepository
    {
        private readonly DBC _context;
        public TreatmentRepository(DBC context) : base(context) => _context = context;

    }
}
