using AutoMapper;
using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MHC.Infrastructure.Repositories
{
    public class ClinicReository : GenericRepository<Clinic>, IClinicRepository
    {
        private readonly DBC _context;
        public ClinicReository(DBC dbc) : base(dbc) => _context = dbc;

        public async Task<List<Clinic>> GetAllIncludeAsync()
        {
            return await _context.Clinics
                .Include(c => c.ClinicType)
                .Include(c => c.Image)
                .ToListAsync();
        }
        
        
    }
}
