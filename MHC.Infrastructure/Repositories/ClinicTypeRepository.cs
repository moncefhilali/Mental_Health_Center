using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class ClinicTypeRepository : GenericRepository<ClinicType>, IClinicTypeRepository
    {
        public ClinicTypeRepository(DBC context) : base(context) { }

        // Additional Methods
    }
}
