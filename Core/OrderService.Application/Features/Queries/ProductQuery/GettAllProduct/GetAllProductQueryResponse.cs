using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.ProductQuery.GettAllProduct
{
    public class GetAllProductQueryResponse 
    {
        public List<Product> products { get; set; }
    }
}
