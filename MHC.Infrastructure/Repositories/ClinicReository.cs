using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class ClinicReository : GenericRepository<Clinic>, IClinicRepository
    {
        public ClinicReository(DBC dbc) : base(dbc) { }
        
        // Additional Methods
    }
}
