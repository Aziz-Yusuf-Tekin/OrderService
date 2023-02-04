using Microsoft.EntityFrameworkCore;
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
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        protected DbSet<Company> _conpany;
        protected OrderServiceContext _context;

        public CompanyReadRepository(OrderServiceContext context) : base(context)
        {
            _context = context;
            _conpany = context.Set<Company>();
        }

        public List<Company> GetCompanyList()
        {
            return _conpany.ToList();
        }
    }
}
