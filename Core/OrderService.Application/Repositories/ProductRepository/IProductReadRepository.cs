using OrderService.Application.Repositories.BaseRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Repositories.ProductRepository
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
        public List<Product> GetAllProductByCompany(Guid companyId);
    }
}
