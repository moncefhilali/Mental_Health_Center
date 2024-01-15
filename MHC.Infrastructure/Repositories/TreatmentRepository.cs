using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Infrastructure.Repositories
{
    public class TreatmentRepository : GenericRepository<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(DBC dbc) : base(dbc) { }
    }
}
