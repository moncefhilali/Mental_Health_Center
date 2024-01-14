using MHC.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Mental_Health_CenterContext _context;
        private readonly DbSet<T> _table;
        public GenericRepository(Mental_Health_CenterContext context) 
        { 
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var r = await _table.ToListAsync();
            return r;
        }
    }
}
