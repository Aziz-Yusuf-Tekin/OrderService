using OrderService.Application.Repositories.CompanyRepository;
using OrderService.Domain.Entities;
using OrderService.Persistence.Context;
using OrderService.Persistence.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Persistence.Repositories.CompanyRepository
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(OrderServiceContext context) : base(context)
        {

        }
    }
}
