using OrderService.Application.Repositories.CustomerRepository;
using OrderService.Domain.Entities;
using OrderService.Persistence.Context;
using OrderService.Persistence.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Persistence.Repositories.CustomerRepository
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(OrderServiceContext context) : base(context)
        {
        }
    }
}
