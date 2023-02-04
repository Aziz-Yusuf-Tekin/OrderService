using Microsoft.EntityFrameworkCore;
using OrderService.Application.Repositories.ProductRepository;
using OrderService.Domain.Entities;
using OrderService.Persistence.Context;
using OrderService.Persistence.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Persistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        protected DbSet<Product> _product;
        protected OrderServiceContext _context;

        public ProductReadRepository(OrderServiceContext context) : base(context)
        {
            _context = context; 
            _product = context.Set<Product>();
        }

        public List<Product> GetAllProductByCompany(Guid companyId)
        {
            return _product.Where(x=>x.CompanyId== companyId)
                .ToList();
        }
    }
}
