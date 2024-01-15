using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(DBC dbc) : base(dbc) { }

        // Additional Methods
    }
}
