using OrderService.Application.Repositories.BaseRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Repositories.CustomerRepository
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
    }
}
