using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class OurServiceRepository : GenericRepository<OurService>, IOurServiceRepository
    {
        public OurServiceRepository(DBC dbc) : base(dbc) { }

        // Additional Methods
    }
}
