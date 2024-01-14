using MHC.Infrastructure.Data;
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
        private readonly DBC _context;
        private readonly DbSet<T> _table;
        public GenericRepository(DBC context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _table.ToListAsync();

        public async Task<T> GetById(Guid id) => await _table.FindAsync(id);

        public async Task CreateAsync(T entity) 
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var data = await _table.FindAsync(id);
            _table.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, T entity)
        {
            var data = await _table.FindAsync(id);
            _context.Entry(data).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

        }
    }
}
