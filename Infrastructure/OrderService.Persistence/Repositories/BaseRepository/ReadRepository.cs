using Microsoft.EntityFrameworkCore;
using OrderService.Application.Repositories.BaseRepository;
using OrderService.Domain.Entities;
using OrderService.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Persistence.Repositories.BaseRepository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly OrderServiceContext _context;
        public ReadRepository(OrderServiceContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }

    }
}
