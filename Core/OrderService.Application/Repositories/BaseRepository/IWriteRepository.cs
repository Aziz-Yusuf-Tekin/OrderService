using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Repositories.BaseRepository
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        bool Remove(T model);
        Task<bool> RemoveAsync(Guid id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
